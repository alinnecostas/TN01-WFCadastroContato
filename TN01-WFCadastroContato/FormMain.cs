namespace TN01_WFCadastroContato
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsCadastrarBotao(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
