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

        public void Inserir(Produto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Produto BuscaPorId (int id)
        {
            return _context.Produto.FirstOrDefault(obj => obj.Id == id);
        }

        public void Deletar(int id)
        {
            var obj = _context.Produto.Find(id);
            _context.Produto.Remove(obj);
            _context.SaveChanges();
        }
    }
}
