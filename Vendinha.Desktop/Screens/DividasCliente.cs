using Vendinha.Models;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens;

public partial class DividasCliente : Form
{
    private readonly ClienteService service;
    private readonly Cliente cliente;

    public DividasCliente(ClienteService service, Cliente cliente)
    {
        InitializeComponent();
        this.service = service;
        this.cliente = cliente;

        lblCliente.Text = $"Cliente: {cliente.Nome}";
        IniciarTabela();
    }

    public void IniciarTabela()
    {
        var dividas = service.ConsultarDividas(cliente.Id);
        CarregarDadosTabela(dividas);
    }

    public void CarregarDadosTabela(List<Divida> dividas)
    {
        dataGridView1.Rows.Clear();

        foreach (var divida in dividas)
        {
            var linha = dataGridView1.Rows.Add(
                divida.Valor.ToString("C2"),
                divida.Paga ? "Paga" : "Em aberto",
                divida.DataCriacao.ToString("dd/MM/yyyy HH:mm"),
                divida.DataPagamento?.ToString("dd/MM/yyyy HH:mm") ?? "-"
                );
            dataGridView1.Rows[linha].Tag = divida.Id;
        }
    }

    private void btnNovaDivida_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtValor.Text, out var valor))
        {
            MessageBox.Show("Informe um valor válido, por exemplo 25,50.", "Nova dívida");
            return;
        }

        var sucesso = service.CriarDivida(cliente.Id, valor, out var erros);
        if (sucesso)
        {
            txtValor.Clear();
            IniciarTabela();
        }
        else
        {
            var mensagem = string.Join(Environment.NewLine, erros.Select(erro => erro.ErrorMessage));
            MessageBox.Show(mensagem, "Falha ao cadastrar a dívida");
        }
    }

    private void btnPagar_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow?.Tag is not int id)
        {
            MessageBox.Show("Selecione uma dívida na lista.");
            return;
        }

        var sucesso = service.PagarDivida(id, out var erro);
        if (sucesso)
        {
            MessageBox.Show("Pagamento registrado com sucesso");
            IniciarTabela();
        }
        else
        {
            MessageBox.Show(erro, "Falha ao registrar o pagamento");
        }
    }
}
