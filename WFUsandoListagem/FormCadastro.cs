using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Campo Login não pode estar Vazio!");

                return;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Campo Confirma Senha não pode estar Vazio!");
                return;
            }


            Usuario us1 = new Usuario();
            us1.Codigo = 0;
            us1.Login = txtLogin.Text;
            us1.Senha = txtSenha.Text;
            us1.ConfirmarSenha = txtConfirmarSenha.Text;
            us1.DataCadastro = DateTime.Now;
          

            if (us1.Senha != us1.ConfirmarSenha)
            {
                MessageBox.Show("As senhas devems ser iguais!");
                return;
            }

            Usuario.ListaUsuarios.Add(us1);

            MessageBox.Show
                ("Cadastrado com Sucesso!");

            Close();

            FormListagem form = new FormListagem();
            form.ShowDialog();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
