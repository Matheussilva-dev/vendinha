namespace Vendinha.Desktop.Screens;

partial class CadastrarCliente
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
        lblNome = new Label();
        txtNome = new TextBox();
        lblCpf = new Label();
        txtCpf = new TextBox();
        lblNascimento = new Label();
        dtpNascimento = new DateTimePicker();
        lblEmail = new Label();
        txtEmail = new TextBox();
        btnSalvar = new Button();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Arial", 24F);
        lblTitulo.Location = new Point(40, 15);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Text = "Novo Cliente";
        //
        // lblNome
        //
        lblNome.AutoSize = true;
        lblNome.Location = new Point(40, 80);
        lblNome.Name = "lblNome";
        lblNome.Text = "Nome completo";
        //
        // txtNome
        //
        txtNome.Location = new Point(40, 100);
        txtNome.MaxLength = 100;
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(300, 23);
        //
        // lblCpf
        //
        lblCpf.AutoSize = true;
        lblCpf.Location = new Point(40, 135);
        lblCpf.Name = "lblCpf";
        lblCpf.Text = "CPF";
        //
        // txtCpf
        //
        txtCpf.Location = new Point(40, 155);
        txtCpf.Name = "txtCpf";
        txtCpf.Size = new Size(300, 23);
        //
        // lblNascimento
        //
        lblNascimento.AutoSize = true;
        lblNascimento.Location = new Point(40, 190);
        lblNascimento.Name = "lblNascimento";
        lblNascimento.Text = "Data de nascimento";
        //
        // dtpNascimento
        //
        dtpNascimento.CustomFormat = "dd/MM/yyyy";
        dtpNascimento.Format = DateTimePickerFormat.Short;
        dtpNascimento.Location = new Point(40, 210);
        dtpNascimento.MaxDate = DateTime.Today;
        dtpNascimento.Name = "dtpNascimento";
        dtpNascimento.Size = new Size(300, 23);
        //
        // lblEmail
        //
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(40, 245);
        lblEmail.Name = "lblEmail";
        lblEmail.Text = "E-mail (opcional)";
        //
        // txtEmail
        //
        txtEmail.Location = new Point(40, 265);
        txtEmail.MaxLength = 200;
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(300, 23);
        //
        // btnSalvar
        //
        btnSalvar.BackColor = Color.DarkBlue;
        btnSalvar.FlatAppearance.BorderSize = 0;
        btnSalvar.FlatStyle = FlatStyle.Flat;
        btnSalvar.Font = new Font("Arial", 12F);
        btnSalvar.ForeColor = Color.White;
        btnSalvar.Location = new Point(40, 310);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(300, 45);
        btnSalvar.Text = "Cadastrar";
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btnSalvar_Click;
        //
        // CadastrarCliente
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 380);
        Controls.Add(btnSalvar);
        Controls.Add(txtEmail);
        Controls.Add(lblEmail);
        Controls.Add(dtpNascimento);
        Controls.Add(lblNascimento);
        Controls.Add(txtCpf);
        Controls.Add(lblCpf);
        Controls.Add(txtNome);
        Controls.Add(lblNome);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CadastrarCliente";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastrar cliente";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Label lblNome;
    private TextBox txtNome;
    private Label lblCpf;
    private TextBox txtCpf;
    private Label lblNascimento;
    private DateTimePicker dtpNascimento;
    private Label lblEmail;
    private TextBox txtEmail;
    private Button btnSalvar;
}
