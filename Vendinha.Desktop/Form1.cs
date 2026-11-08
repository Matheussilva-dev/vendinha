using Vendinha.Services;

namespace Vendinha.Desktop;

public partial class Form1 : Form
{
    private readonly ClienteService service = new ClienteService();
    private int paginaAtual = 1;
    private int totalPaginas = 1;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        CarregarClientes();
    }

    private void CarregarClientes()
    {
        try
        {
            var busca = txtBusca.Text;
            var total = service.Contar(busca);
            totalPaginas = Math.Max(1, (int)Math.Ceiling(total / (double)ClienteService.TamanhoPagina));

            if (paginaAtual > totalPaginas)
            {
                paginaAtual = totalPaginas;
            }

            var clientes = service.Consultar(busca, paginaAtual);

            dgvClientes.Rows.Clear();
            foreach (var c in clientes)
            {
                dgvClientes.Rows.Add(c.Nome, FormatarCpf(c.Cpf), c.Idade, c.TotalDividas);
            }

            lblPagina.Text = $"Página {paginaAtual} de {totalPaginas} ({total} cliente(s))";
            btnAnterior.Enabled = paginaAtual > 1;
            btnProxima.Enabled = paginaAtual < totalPaginas;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Não foi possível carregar os clientes. Verifique se o PostgreSQL está em execução e a conexão está correta.\n\n"
                + ex.GetBaseException().Message,
                "Erro ao acessar o banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static string FormatarCpf(string cpf)
    {
        return cpf.Length == 11
            ? $"{cpf[..3]}.{cpf[3..6]}.{cpf[6..9]}-{cpf[9..]}"
            : cpf;
    }

    private void Buscar()
    {
        paginaAtual = 1;
        CarregarClientes();
    }

    private void btnBuscar_Click(object? sender, EventArgs e)
    {
        Buscar();
    }

    private void txtBusca_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            Buscar();
        }
    }

    private void btnAnterior_Click(object? sender, EventArgs e)
    {
        if (paginaAtual > 1)
        {
            paginaAtual--;
            CarregarClientes();
        }
    }

    private void btnProxima_Click(object? sender, EventArgs e)
    {
        if (paginaAtual < totalPaginas)
        {
            paginaAtual++;
            CarregarClientes();
        }
    }
}
