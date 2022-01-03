using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double ValorVenda { get; set; }

        public Venda()
        {
        }

        public Venda( DateTime dataVenda, Produto produto, int produtoId, int quantidade, double valorVenda)
        {
            
            DataVenda = dataVenda;
            Produto = produto;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            ValorVenda = valorVenda;
        }
    }
}
