using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get; private set; }
        public decimal Total {
            get
            {
                return Itens.Sum(i => i.Subtotal);
            }
        }

        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            this.Itens = itens;
        }
    }
}
