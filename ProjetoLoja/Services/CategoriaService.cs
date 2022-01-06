using ProjetoLoja.Data;
using ProjetoLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Services
{
    public class CategoriaService
    {
        private readonly ProjetoLojaContext _context;

        public CategoriaService(ProjetoLojaContext context)
        {
            _context = context;
        }

        public List<Categoria> Findall()
        {
            return _context.Categoria.OrderBy(x => x.Nome).ToList();
        }
    }
}
