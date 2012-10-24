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

        [Test]
        public void CarrinhoDeveConterOsItensDePedidoQueForemAdicionados()
        {
            var carrinho = new CarrinhoDeComprasService();

            carrinho.AdicionarProduto(new Produto(), 2);
            carrinho.AdicionarProduto(new Produto(), 4); 

            var quantidade = carrinho.ItensDePedido.Count();

            Assert.AreEqual(2, quantidade);
        }
    
    }
}
