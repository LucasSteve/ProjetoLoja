using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Categoria>> FindallAsync()
        {
            return await _context.Categoria.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
