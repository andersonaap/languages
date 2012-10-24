using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Domain
{
    public class CarrinhoDeComprasService
    {
        public IList<ItemDePedido> ItensDePedido { get; set; }

        public CarrinhoDeComprasService()
        {
            ItensDePedido = new List<ItemDePedido>();
        }
    }
}
