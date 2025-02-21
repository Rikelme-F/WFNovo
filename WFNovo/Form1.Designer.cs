namespace WFNovo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login2 = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(60, 75);
            Username.Name = "Username";
            Username.Size = new Size(65, 15);
            Username.TabIndex = 3;
            Username.Text = "User Name";

            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(60, 122);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 4;
            Password.Text = "Password";

            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // Login2
            // 
            Login2.Location = new Point(148, 160);
            Login2.Name = "Login2";
            Login2.Size = new Size(75, 23);
            Login2.TabIndex = 7;
            Login2.Text = "Login";
            Login2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 255);
            Controls.Add(Login2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Username;
        private Label Password;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Login2;
    }
}
