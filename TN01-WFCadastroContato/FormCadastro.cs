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
            mkdTelefone.Clear();
            txtEmail.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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



            string telefone = mkdTelefone.Text;

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




            if (rdbComercial.Checked)
            {
                rdbComercial.Text = "Comercial";
            }
            else if (rdbPessoal.Checked)
            {
                rdbPessoal.Text = "Pessoal";
            }
            else if (rdbRecado.Checked)
            {
                rdbRecado.Text = "Recado";
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi definido!");
                return;
            }


          
            string tipoTelefone = rdbComercial.Text.Substring(0, 1) + ") ";
            tipoTelefone += rdbComercial.Text.Substring(2, 5) + "-" +
                rdbComercial.Text.Substring(7);





            MessageBox.Show("Nome: " + nome + "\nSobrenome: " + sobrenome + 
                "\nTelefone: " + telefone + "\nEmail: " + email + 
                "\nTipo de telefone: " + rdbComercial.Text);
            MessageBox.Show("Pessoa cadastrada com sucesso!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();

        }

     
    }
}
