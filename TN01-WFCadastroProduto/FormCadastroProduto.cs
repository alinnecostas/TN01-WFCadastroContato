using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TN01_WFCadastroProduto.FormLogin;

namespace TN01_WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

  

            private void FormCadastroProduto_Load(object sender, EventArgs e)
        {

            ListaProdutos p = new ListaProdutos();
            p.Codigo = 001;
            p.Categoria = "Alimento";
            p.NomeProduto = "Arroz";
            p.Preco = 5.00;
            p.DataVencimento = Convert.ToDateTime("18/03/2025");
            p.DataVencimento = DateTime.Now;
            p.Observacao = "Arroz de qualidade";


            ListaProdutos.Produtos.Add(p);
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ListaProdutos p = new ListaProdutos();


            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Categoria = cbxCategoria.Text;
            p.NomeProduto = txtNomeProduto.Text;
            p.Preco = Convert.ToDouble(nudPreco.Text);
            p.DataVencimento = dtpVencimento.Value;
            p.DataVencimento = DateTime.Now;
            p.Observacao = txtObservacao.Text;

            ListaProdutos.Produtos.Add(p);



            MessageBox.Show
                ("Cadastrado com Sucesso!");

            Close();



            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();

        }
    }
}
