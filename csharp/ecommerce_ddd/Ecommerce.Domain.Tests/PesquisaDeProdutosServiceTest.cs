using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moq;
using NUnit.Framework;

using Ecommerce.Domain;


namespace Ecommerce.Domain.Tests
{
    [TestFixture]
    public class PesquisaDeProdutosServiceTest
    {
        private IEnumerable<Produto> produtosIniciais;
        
        [SetUp]
        public void SetUp()
        {
            produtosIniciais =
                new Produto[]
                {
                    new Produto { Id = 1, Nome = "SmartTv" },
                    new Produto { Id = 2, Nome = "Ultrabook" },
                    new Produto { Id = 3, Nome = "Smartphone" },
                }
                .AsEnumerable();
        }

        [Test]
        public void DeveListarTodosOsProdutos()
        {
            var produtoRepositoryStub = new Mock<IProdutoRepository>(MockBehavior.Strict);

            produtoRepositoryStub
                .Setup(x => x.GetAll())
                .Returns(produtosIniciais);
                
            var carrinho = new PesquisaDeProdutosService(produtoRepositoryStub.Object);

            var produtosObtidos = carrinho.ListarProdutos();

            CollectionAssert.AreEqual(produtosObtidos, produtosIniciais);
        }
    }
}
