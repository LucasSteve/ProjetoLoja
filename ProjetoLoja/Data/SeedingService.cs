using ProjetoLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Data
{
    public class SeedingService
    {    
        
            public readonly ProjetoLojaContext _context;

            public SeedingService(ProjetoLojaContext context)
            {
                _context = context;
            }

            public void Seed()
            {
                if (_context.Categoria.Any() ||
                    _context.Produto.Any() ||
                    _context.Venda.Any())

                {
                    return; //DB ja foi populado
                }
                Categoria c1 = new Categoria( "Smart Watch");
                Categoria c2 = new Categoria( "Relogios");
                Categoria c3 = new Categoria( "Eletronicos");
                Categoria c4 = new Categoria( "Legos");

                Produto p1 = new Produto( "Smart x50", 10, 150.40, new DateTime(2021, 12, 10), c1, 1);
                Produto p2 = new Produto( "Smart p80x", 5, 180.00, new DateTime(2021, 8, 5), c1, 1);
                Produto p3 = new Produto( "lego batman", 3, 15, new DateTime(2021, 10, 3), c4, 4);
                Produto p4 = new Produto( "lego homem aranha", 15, 13, new DateTime(2021, 9, 16), c4, 4);
                Produto p5 = new Produto( "Relogio Razor", 40, 100, new DateTime(2021, 7, 10), c2, 2);
                Produto p6 = new Produto( "Relogio Mans", 2, 10000, new DateTime(2021, 10, 01), c2, 2);
                Produto p7 = new Produto( "Relogio TamoJunto", 5, 50, new DateTime(2021, 12, 20), c2, 2);
                Produto p8 = new Produto( "Celular Iphone12", 10, 13000, new DateTime(2021, 12, 15), c3, 3);
                Produto p9 = new Produto( "Notebook Razor12", 5, 2360, new DateTime(2021, 11, 06), c3, 3);
                Produto p10 = new Produto( "Maquina de cortar", 5, 600.50, new DateTime(2021, 10, 15), c3, 3);

                Venda v1 = new Venda( new DateTime(2021, 10, 13), p1, 1, 2, 230);
                Venda v2 = new Venda( new DateTime(2021, 12, 13), p2, 2, 4, 300);
                Venda v3 = new Venda( new DateTime(2021, 12, 13), p3, 3, 1, 150);
                Venda v4 = new Venda( new DateTime(2021, 12, 13), p4, 4, 2, 80);
                Venda v5 = new Venda( new DateTime(2021, 11, 13), p5, 5, 3, 500);
                Venda v6 = new Venda( new DateTime(2021, 11, 13), p6, 6, 2, 15000);
                Venda v7 = new Venda( new DateTime(2021, 11, 13), p7, 7, 1, 150);
                Venda v8 = new Venda( new DateTime(2021, 12, 13), p8, 8, 2, 16000);
                Venda v9 = new Venda( new DateTime(2021, 11, 13), p9, 9, 1, 5560);
                Venda v10 = new Venda( new DateTime(2021, 12, 13), p10, 10, 5, 1000);
                Venda v11 = new Venda( new DateTime(2021, 12, 13), p1, 1, 1, 1500);
                Venda v12 = new Venda( new DateTime(2021, 12, 13), p2, 2, 3, 600);
                Venda v13 = new Venda( new DateTime(2021, 12, 13), p5, 5, 5, 2000);
                Venda v14 = new Venda( new DateTime(2021, 11, 13), p9, 9, 6, 3000);
                Venda v15 = new Venda( new DateTime(2021, 11, 13), p6, 6, 9, 3000);
                Venda v16 = new Venda( new DateTime(2021, 12, 13), p7, 7, 2, 1500);
                Venda v17 = new Venda( new DateTime(2021, 12, 13), p3, 3, 4, 600);
                Venda v18 = new Venda( new DateTime(2021, 11, 13), p4, 4, 7, 750.00);


                _context.Categoria.AddRange(c1, c2, c3, c4);
                _context.Produto.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
                _context.Venda.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
                _context.SaveChanges();
            }
        
    }
}
