using Vendinha.Models;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens;

public partial class ListarDividas : Form
{
    private readonly ClienteService service;

    public ListarDividas(ClienteService service)
    {
        InitializeComponent();
        this.service = service;

        cmbSituacao.Items.Add("Todas");
        cmbSituacao.Items.Add("Em aberto");
        cmbSituacao.Items.Add("Pagas");
        cmbSituacao.SelectedIndex = 2;
    }

    public void IniciarTabela()
    {
        bool? paga = cmbSituacao.SelectedIndex switch
        {
            1 => false,
            2 => true,
            _ => null,
        };

        var dividas = service.ConsultarTodasDividas(paga);
        CarregarDadosTabela(dividas);
    }

    public void CarregarDadosTabela(List<(string Cliente, Divida Divida)> dividas)
    {
        dataGridView1.Rows.Clear();

        foreach (var item in dividas)
        {
            var divida = item.Divida;
            var linha = dataGridView1.Rows.Add(
                item.Cliente,
                divida.Valor.ToString("C2"),
                divida.Paga ? "Paga" : "Em aberto",
                divida.DataCriacao.ToString("dd/MM/yyyy HH:mm"),
                divida.DataPagamento?.ToString("dd/MM/yyyy HH:mm") ?? "-"
                );

            if (divida.Paga)
            {
                dataGridView1.Rows[linha].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        var total = dividas.Sum(item => item.Divida.Valor);
        lblResumo.Text = $"{dividas.Count} dívida(s) - total: {total:C2}";
    }

    private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
    {
        IniciarTabela();
    }
}
