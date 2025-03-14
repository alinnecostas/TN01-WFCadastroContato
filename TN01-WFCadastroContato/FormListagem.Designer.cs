namespace TN01_WFCadastroContato
{
    partial class FormListagem
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
            dgvListaContatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaContatos
            // 
            dgvListaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaContatos.Dock = DockStyle.Fill;
            dgvListaContatos.Location = new Point(0, 0);
            dgvListaContatos.Name = "dgvListaContatos";
            dgvListaContatos.Size = new Size(389, 256);
            dgvListaContatos.TabIndex = 0;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 256);
            Controls.Add(dgvListaContatos);
            Name = "FormListagem";
            Text = "FormListagem";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaContatos;
    }
}