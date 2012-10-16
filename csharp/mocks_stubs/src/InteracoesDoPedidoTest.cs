using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Moq;


namespace mocks_stubs
{
    [TestFixture]
    public class InteracoesDoPedidoTest 
    {
        private const string Talisker = "Talisker";
        
        [Test]
        public void TestPreenchimentoRetiraDoEstoqueSeHouverDisponibilidade()
        {
            var pedido = new Pedido(Talisker, 50);
            var estoqueMock = new Mock<IEstoque>();

            estoqueMock
                .Setup(x => x.TemDisponibilidade(Talisker, 50))
                .Returns(true);
            estoqueMock
                .Setup(x => x.Retirar(Talisker, 50));

            pedido.Preencher(estoqueMock.Object);

            estoqueMock.Verify(x => x.TemDisponibilidade(Talisker, 50), Times.Once());
            estoqueMock.Verify(x => x.Retirar(Talisker, 50), Times.Once());
            Assert.IsTrue(pedido.EstaPreenchido());
        }

        [Test]
        public void TestPreenchimentoNaoRetiraDoEstoqueSeNaoHouverDisponibilidade()
        {
            var pedido = new Pedido(Talisker, 51);
            var estoqueMock = new Mock<IEstoque>(MockBehavior.Strict);

            estoqueMock
                .Setup(x => x.TemDisponibilidade(It.IsAny<string>(), It.IsAny<int>()))
                .Returns(false);

            pedido.Preencher(estoqueMock.Object);

            //estoqueMock.VerifyAll(); // para MockBehavior.Loose
            Assert.IsFalse(pedido.EstaPreenchido());
        }

        [Test]
        public void TestPreenchimentoEnviaEmailSeNaoHouverDisponibilidade()
        {
            var pedido = new Pedido(Talisker, 51);
            var estoqueMock = new Mock<IEstoque>();
            var emailServiceMock = new Mock<IEmailService>();
            pedido.DefinirEmailService(emailServiceMock.Object);

            estoqueMock
                .Setup(x => x.TemDisponibilidade(It.IsAny<string>(), It.IsAny<int>()))
                .Returns(false);
            emailServiceMock
                .Setup(x => x.Enviar(It.IsAny<string>()));

            pedido.Preencher(estoqueMock.Object);

            estoqueMock.VerifyAll();
            emailServiceMock.VerifyAll();
        }
    }
}
