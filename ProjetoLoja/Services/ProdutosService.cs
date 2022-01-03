using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Data;
using ProjetoLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Services
{
    public class ProdutosService
    {
        private readonly ProjetoLojaContext _context;

        public ProdutosService(ProjetoLojaContext context)
        {
            _context = context;
        }

        public  List<Produto> Findall()
        {
            return  _context.Produto.ToList();
        }
    }
}
