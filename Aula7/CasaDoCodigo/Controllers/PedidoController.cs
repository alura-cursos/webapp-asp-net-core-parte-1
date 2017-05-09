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
        private readonly IDataService _dataService;
        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }

        public IActionResult Carrossel()
        {
            List<Produto> produtos = _dataService.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            List<Produto> produtos =
                this._dataService.GetProdutos();

            var itensCarrinho = this._dataService.GetItensPedido();

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
