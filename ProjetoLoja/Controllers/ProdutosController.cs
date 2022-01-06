using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Models.ViewModels;
using ProjetoLoja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosService _produtosService;
        private readonly CategoriaService _categoriaService;

        public ProdutosController(ProdutosService produtosService, CategoriaService categoriaService)
        {
            _produtosService = produtosService;
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            var list = _produtosService.Findall();
            return View(list);
        }

        public IActionResult Adicionar()
        {
            var categorias = _categoriaService.Findall();
            var viewModel = new ProdutoFormViewModel { Categorias = categorias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Adicionar(Produto produto)
        {
            _produtosService.Inserir(produto);
            return RedirectToAction(nameof(Index));
        }

        public  IActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _produtosService.BuscaPorId(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _produtosService.Deletar(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
