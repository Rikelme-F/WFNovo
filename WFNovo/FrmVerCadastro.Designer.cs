namespace WFNovo
{
    partial class FrmVerCadastro
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
            lblEmail = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblEstado = new Label();
            lblBairro = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(224, 301);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 17);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(224, 272);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(54, 17);
            lblCelular.TabIndex = 23;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(224, 243);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 17);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(224, 214);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 21;
            lblEstado.Text = "Estado:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(224, 185);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(47, 17);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(224, 156);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(65, 17);
            lblEndereco.TabIndex = 19;
            lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(224, 128);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 17);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome:";
            // 
            // FrmVerCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Name = "FrmVerCadastro";
            Text = "FrmVerCadastro";
            Load += FrmVerCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblEstado;
        private Label lblBairro;
        private Label lblEndereco;
        private Label lblNome;
    }
}