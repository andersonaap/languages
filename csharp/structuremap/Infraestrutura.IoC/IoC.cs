using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;

using Infraestrutura.IoC.DependencyResolution;


namespace Infraestrutura.IoC
{
    public class IoC
    {
        static private IContainer _container;

        static IoC()
        {
            _container = new Container(_ =>
            {
                _.AddRegistry(new DefaultRegistry());
            });
        }

        static public T ObterInstancia<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
