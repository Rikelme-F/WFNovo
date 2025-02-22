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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(128, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(128, 193);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(128, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(146, 23);
            textBox5.TabIndex = 5;
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
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ES", "MG", "RJ", "SP" });
            comboBox1.Location = new Point(128, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(128, 251);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(280, 23);
            textBox6.TabIndex = 8;
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
            lblCelular.Click += label3_Click;
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
            Controls.Add(textBox6);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox6;
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