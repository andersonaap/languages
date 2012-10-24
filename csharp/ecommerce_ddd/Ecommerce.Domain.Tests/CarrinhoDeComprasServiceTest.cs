using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Ecommerce.Domain;


namespace Ecommerce.Domain.Tests
{
    [TestFixture]
    public class CarrinhoDeComprasServiceTest
    {
        [Test]
        public void CarrinhoEhCriadoSemItensDePedido()
        {
            var carrinho = new CarrinhoDeComprasService();

            var vazio = !carrinho.ItensDePedido.Any();

            Assert.IsTrue(vazio);

        }
    }
}
