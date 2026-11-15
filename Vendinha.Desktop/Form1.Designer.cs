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
        lblTitulo = new Label();
        btnListar = new Button();
        btnCadastrar = new Button();
        btnDividas = new Button();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Arial", 24F);
        lblTitulo.Location = new Point(70, 30);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(146, 36);
        lblTitulo.TabIndex = 3;
        lblTitulo.Text = "Vendinha";
        // 
        // btnListar
        // 
        btnListar.Location = new Point(70, 110);
        btnListar.Name = "btnListar";
        btnListar.Size = new Size(200, 50);
        btnListar.TabIndex = 2;
        btnListar.Text = "Listar clientes";
        btnListar.UseVisualStyleBackColor = true;
        btnListar.Click += btnListar_Click;
        // 
        // btnCadastrar
        // 
        btnCadastrar.Location = new Point(70, 180);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(200, 50);
        btnCadastrar.TabIndex = 1;
        btnCadastrar.Text = "Cadastrar cliente";
        btnCadastrar.UseVisualStyleBackColor = true;
        btnCadastrar.Click += btnCadastrar_Click;
        // 
        // btnDividas
        // 
        btnDividas.Location = new Point(70, 250);
        btnDividas.Name = "btnDividas";
        btnDividas.Size = new Size(200, 50);
        btnDividas.TabIndex = 0;
        btnDividas.Text = "Dívidas (pagas)";
        btnDividas.UseVisualStyleBackColor = true;
        btnDividas.Click += btnDividas_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(340, 330);
        Controls.Add(btnDividas);
        Controls.Add(btnCadastrar);
        Controls.Add(btnListar);
        Controls.Add(lblTitulo);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Vendinha - Controle de Contas";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Button btnListar;
    private Button btnCadastrar;
    private Button btnDividas;
}
