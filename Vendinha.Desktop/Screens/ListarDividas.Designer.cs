namespace Vendinha.Desktop.Screens;

partial class ListarDividas
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblSituacao = new Label();
        cmbSituacao = new ComboBox();
        dataGridView1 = new DataGridView();
        colCliente = new DataGridViewTextBoxColumn();
        colValor = new DataGridViewTextBoxColumn();
        colSituacao = new DataGridViewTextBoxColumn();
        colCriacao = new DataGridViewTextBoxColumn();
        colPagamento = new DataGridViewTextBoxColumn();
        lblResumo = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        //
        // lblSituacao
        //
        lblSituacao.AutoSize = true;
        lblSituacao.Location = new Point(12, 17);
        lblSituacao.Name = "lblSituacao";
        lblSituacao.Text = "Situação:";
        //
        // cmbSituacao
        //
        cmbSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSituacao.Location = new Point(75, 13);
        cmbSituacao.Name = "cmbSituacao";
        cmbSituacao.Size = new Size(160, 23);
        cmbSituacao.SelectedIndexChanged += cmbSituacao_SelectedIndexChanged;
        //
        // dataGridView1
        //
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCliente, colValor, colSituacao, colCriacao, colPagamento });
        dataGridView1.Location = new Point(12, 50);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(716, 300);
        //
        // colCliente
        //
        colCliente.FillWeight = 150F;
        colCliente.HeaderText = "Cliente";
        colCliente.Name = "colCliente";
        //
        // colValor
        //
        colValor.HeaderText = "Valor";
        colValor.Name = "colValor";
        //
        // colSituacao
        //
        colSituacao.HeaderText = "Situação";
        colSituacao.Name = "colSituacao";
        //
        // colCriacao
        //
        colCriacao.HeaderText = "Data de criação";
        colCriacao.Name = "colCriacao";
        //
        // colPagamento
        //
        colPagamento.HeaderText = "Data de pagamento";
        colPagamento.Name = "colPagamento";
        //
        // lblResumo
        //
        lblResumo.AutoSize = true;
        lblResumo.Location = new Point(12, 362);
        lblResumo.Name = "lblResumo";
        lblResumo.Text = "";
        //
        // ListarDividas
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(740, 395);
        Controls.Add(lblResumo);
        Controls.Add(dataGridView1);
        Controls.Add(cmbSituacao);
        Controls.Add(lblSituacao);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ListarDividas";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Dívidas de todos os clientes";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSituacao;
    private ComboBox cmbSituacao;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn colCliente;
    private DataGridViewTextBoxColumn colValor;
    private DataGridViewTextBoxColumn colSituacao;
    private DataGridViewTextBoxColumn colCriacao;
    private DataGridViewTextBoxColumn colPagamento;
    private Label lblResumo;
}
