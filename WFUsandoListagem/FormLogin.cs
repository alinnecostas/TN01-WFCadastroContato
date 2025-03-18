namespace WFUsandoListagem
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
            us.Codigo = 1000;
            us.Login = "user";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("10/01/2025");
            //us.DataCadastro = DateTime.Parse("01/01/2000");
            us.DataCadastro = DateTime.Now;
            Usuario.ListaUsuarios.Add(us);

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        FormMain form = new FormMain();
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

        private void FormLogin_Load_1(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1000;
            us.Login = "user";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("10/01/2025");
            //us.DataCadastro = DateTime.Parse("01/01/2000");
            us.DataCadastro = DateTime.Now;
            Usuario.ListaUsuarios.Add(us);

        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
            }
        }




      
    }
}
