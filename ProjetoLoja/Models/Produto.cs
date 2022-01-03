using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double ValorPago { get; set; }
        public DateTime DataCompra { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public List<Venda> Vendas { get; set; }

        public Produto()
        {
        }

        public Produto( string nome, int quantidade, double valorPago, DateTime dataCompra, Categoria categoria, int categoriaId)
        {
            
            Nome = nome;
            Quantidade = quantidade;
            ValorPago = valorPago;
            DataCompra = dataCompra;
            Categoria = categoria;
            CategoriaId = categoriaId;
        }
    }
}
