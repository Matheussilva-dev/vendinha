namespace Vendinha.Desktop.Screens;

partial class DividasCliente
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
        lblCliente = new Label();
        dataGridView1 = new DataGridView();
        colValor = new DataGridViewTextBoxColumn();
        colSituacao = new DataGridViewTextBoxColumn();
        colCriacao = new DataGridViewTextBoxColumn();
        colPagamento = new DataGridViewTextBoxColumn();
        btnPagar = new Button();
        lblValor = new Label();
        txtValor = new TextBox();
        btnNovaDivida = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        //
        // lblCliente
        //
        lblCliente.AutoSize = true;
        lblCliente.Font = new Font("Arial", 14F);
        lblCliente.Location = new Point(12, 12);
        lblCliente.Name = "lblCliente";
        lblCliente.Text = "Cliente";
        //
        // dataGridView1
        //
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colValor, colSituacao, colCriacao, colPagamento });
        dataGridView1.Location = new Point(12, 50);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(626, 250);
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
        // btnPagar
        //
        btnPagar.Location = new Point(12, 312);
        btnPagar.Name = "btnPagar";
        btnPagar.Size = new Size(180, 30);
        btnPagar.Text = "Marcar como paga";
        btnPagar.UseVisualStyleBackColor = true;
        btnPagar.Click += btnPagar_Click;
        //
        // lblValor
        //
        lblValor.AutoSize = true;
        lblValor.Location = new Point(300, 319);
        lblValor.Name = "lblValor";
        lblValor.Text = "Valor (R$):";
        //
        // txtValor
        //
        txtValor.Location = new Point(370, 316);
        txtValor.Name = "txtValor";
        txtValor.Size = new Size(90, 23);
        //
        // btnNovaDivida
        //
        btnNovaDivida.Location = new Point(468, 312);
        btnNovaDivida.Name = "btnNovaDivida";
        btnNovaDivida.Size = new Size(170, 30);
        btnNovaDivida.Text = "Nova dívida";
        btnNovaDivida.UseVisualStyleBackColor = true;
        btnNovaDivida.Click += btnNovaDivida_Click;
        //
        // DividasCliente
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(650, 360);
        Controls.Add(btnNovaDivida);
        Controls.Add(txtValor);
        Controls.Add(lblValor);
        Controls.Add(btnPagar);
        Controls.Add(dataGridView1);
        Controls.Add(lblCliente);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "DividasCliente";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Dívidas do cliente";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblCliente;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn colValor;
    private DataGridViewTextBoxColumn colSituacao;
    private DataGridViewTextBoxColumn colCriacao;
    private DataGridViewTextBoxColumn colPagamento;
    private Button btnPagar;
    private Label lblValor;
    private TextBox txtValor;
    private Button btnNovaDivida;
}
