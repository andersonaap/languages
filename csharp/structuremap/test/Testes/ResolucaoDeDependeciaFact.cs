using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using Xunit;

using Implementacoes;
using Infraestrutura.IoC;
using Interfaces;
using SiteMvc.Controllers;


namespace Testes
{
    public class ResolucaoDeDependeciaFact
    {
        [Fact]
        public void deve_obter_uma_instancia_de_TipoB_ao_desejar_ITipoB()
        {
            var instancia = IoC.ObterInstancia<ITipoB>();
            Assert.IsType<TipoB>(instancia);
        }

        [Fact]
        public void deve_obter_uma_instancia_de_TipoC_e_suas_depencias_recebidas_por_construtor_ao_desejar_ITipoC()
        {
            var instancia = IoC.ObterInstancia<ITipoC>();
            Assert.IsType<TipoC>(instancia);
            Assert.IsType<TipoD>(((TipoC)instancia).Dependencia);
        }

        [Fact]
        public void deve_executar_action_da_HomeController_e_obter_RetornoOK_no_ViewBagMensagem()
        {
            var tipoE = IoC.ObterInstancia<ITipoE>();
            var controller = new HomeController(tipoE);
            // ou
            //var controller = IoC.ObterInstancia<HomeController>();

            var viewResult = controller.Index() as ViewResult;
            var obtido = (string)viewResult.ViewBag.Mensagem;

            var esperado = "RetornoOK";

            Assert.Equal(esperado, obtido);
        }
    }
}
