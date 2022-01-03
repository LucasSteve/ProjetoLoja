using Microsoft.AspNetCore.Mvc;
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

        public ProdutosController(ProdutosService produtosService)
        {
            _produtosService = produtosService;
        }

        public IActionResult Index()
        {
            var list = _produtosService.Findall();
            return View(list);
        }
    }
}
