namespace TN01_WFCadastroContato
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            label2 = new Label();
            lblLinha = new Label();
            mkdTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            label1 = new Label();
            gbxTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbPessoal = new RadioButton();
            rdbComercial = new RadioButton();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            gbxTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(41, 47);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(182, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(301, 65);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(193, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 47);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Sobrenome";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(43, 104);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(453, 1);
            lblLinha.TabIndex = 4;
            lblLinha.Text = "label1";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(43, 142);
            mkdTelefone.Mask = "(00) 90000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(96, 23);
            mkdTelefone.TabIndex = 5;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(43, 124);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(43, 209);
            label1.Name = "label1";
            label1.Size = new Size(453, 1);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // gbxTelefone
            // 
            gbxTelefone.Controls.Add(rdbRecado);
            gbxTelefone.Controls.Add(rdbPessoal);
            gbxTelefone.Controls.Add(rdbComercial);
            gbxTelefone.Location = new Point(208, 122);
            gbxTelefone.Name = "gbxTelefone";
            gbxTelefone.Size = new Size(288, 60);
            gbxTelefone.TabIndex = 8;
            gbxTelefone.TabStop = false;
            gbxTelefone.Text = "Tipo de Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(178, 20);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(97, 20);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 1;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(11, 20);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 0;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 262);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(451, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(43, 244);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(419, 371);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 36);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(305, 371);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(88, 36);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 444);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(gbxTelefone);
            Controls.Add(label1);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(lblLinha);
            Controls.Add(txtSobrenome);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            gbxTelefone.ResumeLayout(false);
            gbxTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label label2;
        private Label lblLinha;
        private MaskedTextBox mkdTelefone;
        private Label lblTelefone;
        private Label label1;
        private GroupBox gbxTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}