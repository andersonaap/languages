using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using StructureMap.Configuration.DSL;
using StructureMap.Configuration.DSL.Expressions;
using StructureMap.Graph;

namespace Interfaces
{
    public class InterfacesRegistry : Registry
    {
        public InterfacesRegistry()
        {
            // For<ObjectContext>().HybridHttpOrThreadLocalScoped().Use(() => new Entities());

            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            For<ITipoB>().Use<TipoB>();
        }
    }
}
