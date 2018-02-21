using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo
{
    public interface IDataService
    {
        void InicializaDB();
        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();
    }
}