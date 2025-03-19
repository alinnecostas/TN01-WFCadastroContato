using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroProduto
{
    public partial class FormListaProduto : Form
    {
        public FormListaProduto()
        {
            InitializeComponent();
        }

        private void FormListaProduto_Load(object sender, EventArgs e)
        {

            dvgListaProdutos.DataSource = ListaProdutos.Produtos;

        }
    }
}
