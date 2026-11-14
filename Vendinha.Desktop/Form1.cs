using Vendinha.Desktop.Screens;
using Vendinha.Services;

namespace Vendinha.Desktop;

public partial class Form1 : Form
{
    public Form1()
    {
        Service = new ClienteService();
        InitializeComponent();
    }

    public ClienteService Service { get; private set; }

    private void btnListar_Click(object sender, EventArgs e)
    {
        var tela = new ListarClientes(Service);
        tela.ShowDialog(this);
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        var tela = new CadastrarCliente(Service);
        tela.ShowDialog(this);
    }
}
