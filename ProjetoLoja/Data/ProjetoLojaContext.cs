using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Models;

namespace ProjetoLoja.Data
{
    public class ProjetoLojaContext : DbContext
    {
        public ProjetoLojaContext (DbContextOptions<ProjetoLojaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoLoja.Models.Categoria> Categoria { get; set; }
        public DbSet<ProjetoLoja.Models.Produto> Produto { get; set; }
        public DbSet<ProjetoLoja.Models.Venda> Venda { get; set; }
    }
}
