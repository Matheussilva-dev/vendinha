using Vendinha.Models;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens;

public partial class ListarClientes : Form
{
    private readonly ClienteService service;
    private int pagina = 1;
    private int totalPaginas = 1;

    public ListarClientes(ClienteService service)
    {
        InitializeComponent();
        this.service = service;
        IniciarTabela();
    }

    public void IniciarTabela()
    {
        var busca = txtBusca.Text;
        var total = service.Contar(busca);

        totalPaginas = (int)Math.Ceiling(total / (double)ClienteService.TamanhoPagina);
        if (totalPaginas < 1)
        {
            totalPaginas = 1;
        }
        if (pagina > totalPaginas)
        {
            pagina = totalPaginas;
        }

        var clientes = service.Consultar(busca, pagina);
        CarregarDadosTabela(clientes);

        lblPagina.Text = $"Página {pagina} de {totalPaginas}";
        btnAnterior.Enabled = pagina > 1;
        btnProxima.Enabled = pagina < totalPaginas;
    }

    public void CarregarDadosTabela(List<Cliente> clientes)
    {
        dataGridView1.Rows.Clear();

        foreach (var cliente in clientes)
        {
            var linha = dataGridView1.Rows.Add(
                cliente.Nome,
                cliente.Idade,
                cliente.TotalDividas.ToString("C2")
                );
            dataGridView1.Rows[linha].Tag = cliente.Id;
        }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        pagina = 1;
        IniciarTabela();
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
        pagina--;
        IniciarTabela();
    }

    private void btnProxima_Click(object sender, EventArgs e)
    {
        pagina++;
        IniciarTabela();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow?.Tag is not int id)
        {
            MessageBox.Show("Selecione um cliente na lista.");
            return;
        }

        var cliente = service.ObterPorId(id);
        if (cliente == null)
        {
            MessageBox.Show("Cliente não encontrado.");
            return;
        }

        var tela = new CadastrarCliente(service, cliente);
        tela.ShowDialog(this);
        IniciarTabela();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow?.Tag is not int id)
        {
            MessageBox.Show("Selecione um cliente na lista.");
            return;
        }

        var nome = dataGridView1.CurrentRow.Cells[0].Value;
        var resposta = MessageBox.Show(
            $"Deseja excluir o cliente {nome} e todas as suas dívidas?",
            "Excluir cliente",
            MessageBoxButtons.YesNo);

        if (resposta == DialogResult.Yes)
        {
            service.Excluir(id);
            IniciarTabela();
        }
    }

    private void btnDividas_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow?.Tag is not int id)
        {
            MessageBox.Show("Selecione um cliente na lista.");
            return;
        }

        var cliente = service.ObterPorId(id);
        if (cliente == null)
        {
            MessageBox.Show("Cliente não encontrado.");
            return;
        }

        var tela = new DividasCliente(service, cliente);
        tela.ShowDialog(this);
        IniciarTabela();
    }
}
