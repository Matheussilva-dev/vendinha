namespace Vendinha.Desktop;

partial class Form1
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
        lblBusca = new Label();
        txtBusca = new TextBox();
        btnBuscar = new Button();
        dgvClientes = new DataGridView();
        colNome = new DataGridViewTextBoxColumn();
        colCpf = new DataGridViewTextBoxColumn();
        colIdade = new DataGridViewTextBoxColumn();
        colTotalDividas = new DataGridViewTextBoxColumn();
        btnAnterior = new Button();
        btnProxima = new Button();
        lblPagina = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
        SuspendLayout();

        // lblBusca
        lblBusca.AutoSize = true;
        lblBusca.Location = new Point(12, 17);
        lblBusca.Text = "Buscar por nome:";

        // txtBusca
        txtBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtBusca.Location = new Point(125, 13);
        txtBusca.Size = new Size(535, 27);
        txtBusca.KeyDown += txtBusca_KeyDown;

        // btnBuscar
        btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBuscar.Location = new Point(670, 12);
        btnBuscar.Size = new Size(100, 29);
        btnBuscar.Text = "Buscar";
        btnBuscar.Click += btnBuscar_Click;

        // dgvClientes
        dgvClientes.AllowUserToAddRows = false;
        dgvClientes.AllowUserToDeleteRows = false;
        dgvClientes.AllowUserToResizeRows = false;
        dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNome, colCpf, colIdade, colTotalDividas });
        dgvClientes.Location = new Point(12, 52);
        dgvClientes.MultiSelect = false;
        dgvClientes.ReadOnly = true;
        dgvClientes.RowHeadersVisible = false;
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClientes.Size = new Size(758, 340);

        // colunas
        colNome.HeaderText = "Nome";
        colNome.FillWeight = 200F;
        colCpf.HeaderText = "CPF";
        colCpf.FillWeight = 80F;
        colIdade.HeaderText = "Idade";
        colIdade.FillWeight = 40F;
        colTotalDividas.HeaderText = "Total de dívidas";
        colTotalDividas.FillWeight = 80F;
        colTotalDividas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        colTotalDividas.DefaultCellStyle.Format = "C2";

        // btnAnterior
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.Location = new Point(12, 402);
        btnAnterior.Size = new Size(100, 29);
        btnAnterior.Text = "< Anterior";
        btnAnterior.Click += btnAnterior_Click;

        // lblPagina
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblPagina.Location = new Point(118, 402);
        lblPagina.Size = new Size(546, 29);
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;

        // btnProxima
        btnProxima.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnProxima.Location = new Point(670, 402);
        btnProxima.Size = new Size(100, 29);
        btnProxima.Text = "Próxima >";
        btnProxima.Click += btnProxima_Click;

        // Form1
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(782, 443);
        MinimumSize = new Size(600, 350);
        Controls.Add(lblBusca);
        Controls.Add(txtBusca);
        Controls.Add(btnBuscar);
        Controls.Add(dgvClientes);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnProxima);
        Text = "Vendinha - Controle de Contas";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblBusca;
    private TextBox txtBusca;
    private Button btnBuscar;
    private DataGridView dgvClientes;
    private DataGridViewTextBoxColumn colNome;
    private DataGridViewTextBoxColumn colCpf;
    private DataGridViewTextBoxColumn colIdade;
    private DataGridViewTextBoxColumn colTotalDividas;
    private Button btnAnterior;
    private Button btnProxima;
    private Label lblPagina;
}
