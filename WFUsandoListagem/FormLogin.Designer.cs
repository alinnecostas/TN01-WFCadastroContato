namespace WFUsandoListagem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(84, 80);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe o login";
            txtLogin.Size = new Size(159, 23);
            txtLogin.TabIndex = 0;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(84, 128);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe a senha";
            txtSenha.Size = new Size(159, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(127, 177);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(312, 306);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "FormLogin";
            Text = "Autenticação";
            Load += FormLogin_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnLogar;
    }
}
