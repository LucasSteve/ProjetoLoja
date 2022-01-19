using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Data;
using ProjetoLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoLoja.Services.Excecoes;

namespace ProjetoLoja.Services
{
    public class ProdutosService
    {
        private readonly ProjetoLojaContext _context;

        public ProdutosService(ProjetoLojaContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> FindallAsync()
        {
            return await  _context.Produto.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task InserirAsync(Produto obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Produto> BuscaPorIdAsync (int id)
        {
            return await _context.Produto.Include(obj => obj.Categoria).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task Deletar(int id)
        {
            var obj = await _context.Produto.FindAsync(id);
            _context.Produto.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Produto obj)
        {
            if (!await _context.Produto.AnyAsync(x => x.Id == obj.Id))
            {
                throw new NotFoundExcepction("Id não encontrado!");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
