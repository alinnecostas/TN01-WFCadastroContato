using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mtbDddTelefone.Clear();
            txtEmail.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string semMaskTelefone = mtbDddTelefone.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");

            string nome = txtNome.Text;

            if (nome.Length == 0) {
                MessageBox.Show("O campo nome é obrigatório!");
                return;
            }



           string sobrenome = txtSobrenome.Text;

            if (sobrenome.Length == 0)
            {
                MessageBox.Show("O campo sobrenome é obrigatório!");
                return;
            }



            string telefone = mtbDddTelefone.Text;

            if (telefone.Length == 0)
            {
                MessageBox.Show("O campo telefone é obrigatório!");
                return;
            }



            string email = txtEmail.Text;

            if (email.Length == 0)
            {
                MessageBox.Show("O campo email é obrigatório!");
                return;
            }



            ETipoTelefone tipoTelefone;
            if (rdbComercial.Checked)
            {
               tipoTelefone = ETipoTelefone.Comercial;
            }
            else if (rdbPessoal.Checked)
            {
                tipoTelefone = ETipoTelefone.Pessoal;
            }
            else if (rdbRecado.Checked)
            {
                tipoTelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi definido!");
                return;
            }


          

            Contato c1 = new Contato();
            c1.Nome = txtNome.Text;
            c1.Sobrenome = txtSobrenome.Text;
            c1.Telefone = mtbDddTelefone.Text;
            c1.Email = txtEmail.Text;
            c1.Codigo = 0;
            c1.TipoTelefone = tipoTelefone;
            
            c1.DDD = mtbDddTelefone.Text.Substring(0, 2);
            c1.Telefone = mtbDddTelefone.Text.Substring(3);

            Contato.ListaContatos.Add(c1);
            
       

            MessageBox.Show("Nome: " + nome + "\nSobrenome: " + sobrenome + 
                "\nTelefone: " + telefone + "\nEmail: " + email + 
                "\nTipo de telefone: " + rdbComercial.Text);
            DialogResult dialogResult = MessageBox.Show("Pessoa cadastrada com sucesso!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();

        }

     
    }
}
