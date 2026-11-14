namespace Vendinha.Desktop.Screens;

partial class ListarClientes
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
        btnEditar = new Button();
        btnExcluir = new Button();
        btnDividas = new Button();
        dataGridView1 = new DataGridView();
        colNome = new DataGridViewTextBoxColumn();
        colIdade = new DataGridViewTextBoxColumn();
        colTotalDividas = new DataGridViewTextBoxColumn();
        btnAnterior = new Button();
        lblPagina = new Label();
        btnProxima = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        //
        // lblBusca
        //
        lblBusca.AutoSize = true;
        lblBusca.Location = new Point(12, 17);
        lblBusca.Name = "lblBusca";
        lblBusca.Text = "Buscar por nome:";
        //
        // txtBusca
        //
        txtBusca.Location = new Point(125, 13);
        txtBusca.Name = "txtBusca";
        txtBusca.Size = new Size(350, 23);
        //
        // btnBuscar
        //
        btnBuscar.Location = new Point(485, 11);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(90, 27);
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        //
        // btnEditar
        //
        btnEditar.Location = new Point(12, 358);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(100, 28);
        btnEditar.Text = "Editar";
        btnEditar.UseVisualStyleBackColor = true;
        btnEditar.Click += btnEditar_Click;
        //
        // btnExcluir
        //
        btnExcluir.Location = new Point(118, 358);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(100, 28);
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = true;
        btnExcluir.Click += btnExcluir_Click;
        //
        // btnDividas
        //
        btnDividas.Location = new Point(224, 358);
        btnDividas.Name = "btnDividas";
        btnDividas.Size = new Size(100, 28);
        btnDividas.Text = "Dívidas";
        btnDividas.UseVisualStyleBackColor = true;
        btnDividas.Click += btnDividas_Click;
        //
        // dataGridView1
        //
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNome, colIdade, colTotalDividas });
        dataGridView1.Location = new Point(12, 50);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(663, 300);
        //
        // colNome
        //
        colNome.FillWeight = 200F;
        colNome.HeaderText = "Nome";
        colNome.Name = "colNome";
        //
        // colIdade
        //
        colIdade.FillWeight = 50F;
        colIdade.HeaderText = "Idade";
        colIdade.Name = "colIdade";
        //
        // colTotalDividas
        //
        colTotalDividas.FillWeight = 100F;
        colTotalDividas.HeaderText = "Total de dívidas";
        colTotalDividas.Name = "colTotalDividas";
        //
        // btnAnterior
        //
        btnAnterior.Location = new Point(12, 398);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Size = new Size(100, 28);
        btnAnterior.Text = "< Anterior";
        btnAnterior.UseVisualStyleBackColor = true;
        btnAnterior.Click += btnAnterior_Click;
        //
        // lblPagina
        //
        lblPagina.Location = new Point(118, 398);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(451, 28);
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        //
        // btnProxima
        //
        btnProxima.Location = new Point(575, 398);
        btnProxima.Name = "btnProxima";
        btnProxima.Size = new Size(100, 28);
        btnProxima.Text = "Próxima >";
        btnProxima.UseVisualStyleBackColor = true;
        btnProxima.Click += btnProxima_Click;
        //
        // ListarClientes
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(690, 440);
        Controls.Add(btnProxima);
        Controls.Add(lblPagina);
        Controls.Add(btnAnterior);
        Controls.Add(dataGridView1);
        Controls.Add(btnDividas);
        Controls.Add(btnExcluir);
        Controls.Add(btnEditar);
        Controls.Add(btnBuscar);
        Controls.Add(txtBusca);
        Controls.Add(lblBusca);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ListarClientes";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Listar clientes";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblBusca;
    private TextBox txtBusca;
    private Button btnBuscar;
    private Button btnEditar;
    private Button btnExcluir;
    private Button btnDividas;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn colNome;
    private DataGridViewTextBoxColumn colIdade;
    private DataGridViewTextBoxColumn colTotalDividas;
    private Button btnAnterior;
    private Label lblPagina;
    private Button btnProxima;
}
