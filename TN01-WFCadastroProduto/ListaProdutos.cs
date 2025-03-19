using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastroProduto
{
    internal class ListaProdutos
    {
        public int Codigo { get; set; }
        public string? Categoria { get; set; }
        public string? NomeProduto { get; set; }
        public double Preco { get; set; }
        public string? Observacao { get; set; }
        public DateTime DataVencimento { get; set; }



        public static List<ListaProdutos> Produtos = new List<ListaProdutos>();
    }
}
