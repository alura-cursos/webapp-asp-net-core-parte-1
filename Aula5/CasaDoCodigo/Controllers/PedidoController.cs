using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto(1, "Sleep not found", 59.90m),
            new Produto(2, "May the code be with you", 59.90m),
            new Produto(3, "Rollback", 59.90m),
            new Produto(4, "REST", 69.90m),
            new Produto(5, "Design Patterns com Java", 69.90m),
            new Produto(6, "Vire o jogo com Spring Framework", 69.90m),
            new Produto(7, "Test-Driven Development", 69.90m),
            new Produto(8, "iOS: Programe para iPhone e iPad", 69.90m),
            new Produto(9, "Desenvolvimento de Jogos para Android", 69.90m)
        };

        public IActionResult Carrossel()
        {

            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            var itensCarrinho = new List<ItemPedido>
            {
                new ItemPedido(1, produtos[0], 1),
                new ItemPedido(2, produtos[1], 2),
                new ItemPedido(3, produtos[2], 3)
            };

            CarrinhoViewModel viewModel =
                new CarrinhoViewModel(itensCarrinho);
            return viewModel;
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }
    }
}
