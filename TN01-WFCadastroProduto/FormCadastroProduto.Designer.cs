namespace TN01_WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            dtpVencimento = new DateTimePicker();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            btnSalvar = new Button();
            nudPreco = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(49, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(49, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(233, 26);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Ração", "Petiscos", "Suplementos", "Coleiras", "Roupas", "Camas", "Brinquedos", "Shampoos", "Escovas", "Tapetes", "Medicamentos", "Antipulgas", "Vitaminas", "Caixas", "Bolsas", "Cintos", "Aquários", "Filtros", "Decorações", "Gaiolas", "Bebedouros" });
            cbxCategoria.Location = new Point(233, 44);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 3;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(49, 108);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(305, 23);
            txtNomeProduto.TabIndex = 5;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(49, 90);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 4;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(49, 154);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(199, 154);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(113, 15);
            lblDataVencimento.TabIndex = 8;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // dtpVencimento
            // 
            dtpVencimento.Location = new Point(199, 176);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(155, 23);
            dtpVencimento.TabIndex = 9;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(255, 255, 192);
            txtObservacao.Location = new Point(49, 240);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(305, 84);
            txtObservacao.TabIndex = 10;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(49, 222);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 11;
            lblObservacao.Text = "Observação";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.HighlightText;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvar.Location = new Point(252, 345);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 31);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(49, 176);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 13;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(400, 398);
            Controls.Add(nudPreco);
            Controls.Add(btnSalvar);
            Controls.Add(lblObservacao);
            Controls.Add(txtObservacao);
            Controls.Add(dtpVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(cbxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblCategoria;
        private ComboBox cbxCategoria;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lblDataVencimento;
        private DateTimePicker dtpVencimento;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private Button btnSalvar;
        private NumericUpDown nudPreco;
    }
}