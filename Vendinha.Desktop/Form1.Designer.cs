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
        lblTitulo = new Label();
        btnListar = new Button();
        btnCadastrar = new Button();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Arial", 24F);
        lblTitulo.Location = new Point(70, 30);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Text = "Vendinha";
        //
        // btnListar
        //
        btnListar.Location = new Point(70, 110);
        btnListar.Name = "btnListar";
        btnListar.Size = new Size(200, 50);
        btnListar.Text = "Listar clientes";
        btnListar.UseVisualStyleBackColor = true;
        btnListar.Click += btnListar_Click;
        //
        // btnCadastrar
        //
        btnCadastrar.Location = new Point(70, 180);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(200, 50);
        btnCadastrar.Text = "Cadastrar cliente";
        btnCadastrar.UseVisualStyleBackColor = true;
        btnCadastrar.Click += btnCadastrar_Click;
        //
        // Form1
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(340, 270);
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
}
