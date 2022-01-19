using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Models
{
    public class Produto
    {
       

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        public int Quantidade { get; set; }
        [Display(Name = "Valor pago")]        
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public double ValorPago { get; set; } 
        [Display(Name ="Data de compra")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo obrigatorio")]
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
