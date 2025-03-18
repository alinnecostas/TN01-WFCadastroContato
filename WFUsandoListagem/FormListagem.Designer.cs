namespace WFUsandoListagem
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
            dgdListagem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgdListagem).BeginInit();
            SuspendLayout();
            // 
            // dgdListagem
            // 
            dgdListagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdListagem.Dock = DockStyle.Fill;
            dgdListagem.Location = new Point(0, 0);
            dgdListagem.Name = "dgdListagem";
            dgdListagem.Size = new Size(800, 450);
            dgdListagem.TabIndex = 0;
            dgdListagem.CellContentClick += dgdListagem_CellContentClick;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgdListagem);
            Name = "FormListagem";
            Text = "FormListagem";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgdListagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgdListagem;
    }
}