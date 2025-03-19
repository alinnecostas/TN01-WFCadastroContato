namespace TN01_WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        private void FormLogin_Load(object sender, EventArgs e)
        {

            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("18/03/2025");
            us.DataCadastro = DateTime.Now;
            Usuario.ListaUsuarios.Add(us);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        FormMenu form = new FormMenu();
                        form.ShowDialog();

                        this.txtLogin.Clear();
                        this.txtSenha.Clear();

                        return;
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }
    }
}
