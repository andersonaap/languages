using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;


namespace mocks_stubs
{
    [TestFixture]
    public class EstadosDoPedidoTest 
    {
        private const string Talisker = "Talisker";
        private const string HighlandPark = "Highland Park";
        private IEstoque _estoque = new Estoque();

        [SetUp]
        public void Setup()
        {
            _estoque.Incluir(Talisker, 50);
            _estoque.Incluir(HighlandPark, 25);
        }
        
        [Test]
        public void TestPedidoEstarPreenchidoSeHaverDisponibilidadeNoEstoque()
        {
            var pedido = new Pedido(Talisker, 50);
            pedido.Preencher(_estoque);
            Assert.IsTrue(pedido.EstaPreenchido());
            Assert.AreEqual(0, _estoque.ObterDisponibilidade(Talisker));
        }

        [Test]
        public void TestPedidoNaoEstarPreenchidoSeNaoHouverDisponibilidade()
        {
            var pedido = new Pedido(Talisker, 51);
            pedido.Preencher(_estoque);
            Assert.IsFalse(pedido.EstaPreenchido());
            Assert.AreEqual(50, _estoque.ObterDisponibilidade(Talisker));
        }
    }
}
