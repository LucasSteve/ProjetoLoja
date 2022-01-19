using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Models.ViewModels;
using ProjetoLoja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoLoja.Services.Excecoes;
using System.Diagnostics;

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

        public async Task<IActionResult> Index()
        {
            var list = await _produtosService.FindallAsync();
            return View(list);
        }

        public async Task<IActionResult> Adicionar()
        {
            var categorias = await _categoriaService.FindallAsync();
            var viewModel = new ProdutoFormViewModel { Categorias = categorias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(Produto produto)
        {
            await _produtosService.InserirAsync(produto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Excluir(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            var obj = await _produtosService.BuscaPorIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _produtosService.Deletar(id);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            var obj = await _produtosService.BuscaPorIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);

        }

        public async Task<IActionResult> Editar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }
            var obj =await _produtosService.BuscaPorIdAsync(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            List<Categoria> categorias = await _categoriaService.FindallAsync();
            ProdutoFormViewModel viewModel = new ProdutoFormViewModel { Produto = obj, Categorias = categorias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, Produto produto)
        {
            if(id != produto.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não correspondem!" });
            }
            try
            {
                await _produtosService.AtualizarAsync(produto);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }              

        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
