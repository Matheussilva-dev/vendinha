using Vendinha.Models;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens;

public partial class CadastrarCliente : Form
{
    private readonly ClienteService service;
    private readonly Cliente? clienteEditado;

    
    public CadastrarCliente(ClienteService service)
    {
        InitializeComponent();
        this.service = service;
    }

    public CadastrarCliente(ClienteService service, Cliente cliente) : this(service)
    {
        clienteEditado = cliente;
        Text = "Editar cliente";
        lblTitulo.Text = "Editar Cliente";
        btnSalvar.Text = "Salvar";

        txtNome.Text = cliente.Nome;
        txtCpf.Text = cliente.Cpf;
        txtEmail.Text = cliente.Email;
        dtpNascimento.Value = cliente.DataNascimento;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        var cliente = new Cliente()
        {
            Id = clienteEditado?.Id ?? 0,
            Nome = txtNome.Text,
            Cpf = txtCpf.Text,
            Email = txtEmail.Text,
            DataNascimento = dtpNascimento.Value.Date,
        };

        List<System.ComponentModel.DataAnnotations.ValidationResult> erros;
        bool sucesso;

        if (clienteEditado == null)
        {
            sucesso = service.Criar(cliente, out erros);
        }
        else
        {
            sucesso = service.Atualizar(cliente, out erros);
        }

        if (sucesso)
        {
            MessageBox.Show("Cliente salvo com sucesso");
            Close();
        }
        else
        {
            var mensagem = string.Join(Environment.NewLine, erros.Select(erro => erro.ErrorMessage));
            MessageBox.Show(mensagem, "Falha ao salvar o cliente");
        }
    }
}
