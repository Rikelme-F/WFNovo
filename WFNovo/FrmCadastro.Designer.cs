namespace WFNovo
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            label2 = new Label();
            txtEstado = new ComboBox();
            txtEmail = new TextBox();
            lblNome = new Label();
            lblEndereço = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            lblEmail = new Label();
            btnGravarCadastro = new Button();
            btnNovoCadastro = new Button();
            btnVerCadastros = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 322);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(128, 106);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(280, 23);
            txtEndereco.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(128, 135);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(280, 23);
            txtBairro.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(128, 193);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(146, 23);
            txtTelefone.TabIndex = 4;
            txtTelefone.TextChanged += textBox4_TextChanged;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(128, 222);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(146, 23);
            txtCelular.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 38);
            label2.Name = "label2";
            label2.Size = new Size(284, 17);
            label2.TabIndex = 6;
            label2.Text = "Preencha os campos e clique em Gravar Dados";
            // 
            // txtEstado
            // 
            txtEstado.FormattingEnabled = true;
            txtEstado.Items.AddRange(new object[] { "ES", "MG", "RJ", "SP" });
            txtEstado.Location = new Point(128, 163);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(188, 23);
            txtEstado.TabIndex = 7;
            txtEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(60, 78);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 17);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome:";
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEndereço.Location = new Point(60, 106);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(65, 17);
            lblEndereço.TabIndex = 12;
            lblEndereço.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(60, 135);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(47, 17);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(60, 164);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(60, 193);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 17);
            lblTelefone.TabIndex = 15;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(60, 222);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(54, 17);
            lblCelular.TabIndex = 16;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(60, 251);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 17);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            // 
            // btnGravarCadastro
            // 
            btnGravarCadastro.Location = new Point(32, 296);
            btnGravarCadastro.Name = "btnGravarCadastro";
            btnGravarCadastro.Size = new Size(101, 41);
            btnGravarCadastro.TabIndex = 18;
            btnGravarCadastro.Text = "Gravar Cadastro";
            btnGravarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Location = new Point(163, 296);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(111, 41);
            btnNovoCadastro.TabIndex = 19;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            // 
            // btnVerCadastros
            // 
            btnVerCadastros.Location = new Point(291, 296);
            btnVerCadastros.Name = "btnVerCadastros";
            btnVerCadastros.Size = new Size(117, 41);
            btnVerCadastros.TabIndex = 20;
            btnVerCadastros.Text = "Ver Cadastros";
            btnVerCadastros.UseVisualStyleBackColor = true;
            btnVerCadastros.Click += btnVerCadastros_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 385);
            Controls.Add(btnVerCadastros);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnGravarCadastro);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereço);
            Controls.Add(lblNome);
            Controls.Add(txtEmail);
            Controls.Add(txtEstado);
            Controls.Add(label2);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private Label label2;
        private ComboBox txtEstado;
        private TextBox txtEmail;
        private Label lblNome;
        private Label lblEndereço;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblTelefone;
        private Label lblCelular;
        private Label lblEmail;
        private Button btnGravarCadastro;
        private Button btnNovoCadastro;
        private Button btnVerCadastros;
    }
}