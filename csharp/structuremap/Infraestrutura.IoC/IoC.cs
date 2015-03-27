using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;


namespace Infraestrutura.IoC
{
    public class IoC
    {
        static private IContainer _container;

        static IoC()
        {
            _container = new Container(_ =>
            {
                _.Scan(scan =>
                {
                    scan.Assembly("Implementacoes");
                    scan.Assembly("Interfaces");
                    //scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            });
        }

        static public T ObterInstancia<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
