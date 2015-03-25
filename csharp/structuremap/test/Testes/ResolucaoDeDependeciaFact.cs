using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;
using StructureMap.Graph;
using StructureMap.Configuration.DSL;
using Xunit;

using Implementacoes;
using Interfaces;


namespace Testes
{
    public class ResolucaoDeDependeciaFact : IDisposable
    {
        private IContainer _container;

        public ResolucaoDeDependeciaFact()
        {
            _container = new Container(_ =>
            {
                _.AddRegistry<InterfacesRegistry>();
                _.Scan(x =>
                {
                    //x.Assembly("Implementacoes");
                    //x.Assembly("Interfaces");
                    x.TheCallingAssembly(); // x.Assembly("Testes"); // 
                    x.WithDefaultConventions();
                });
                //_.For<ITipoB>().Use<TipoB>();
            });
        }

        [Fact]
        public void deve_obter_uma_instancia_de_TipoA_ao_desejar_ITipoA()
        {
            var instancia = _container.GetInstance<ITipoA>();
            Assert.IsType<TipoA>(instancia);
        }

        [Fact]
        public void deve_obter_uma_instancia_de_TipoB_ao_desejar_ITipoB()
        {
            var instancia = _container.GetInstance<ITipoB>();
            Assert.IsType<TipoB>(instancia);
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }

    public interface ITipoA { }

    public class TipoA : ITipoA { }
}
