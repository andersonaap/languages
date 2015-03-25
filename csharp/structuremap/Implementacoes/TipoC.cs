using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;


namespace Implementacoes
{
    public class TipoC : ITipoC
    {
        private ITipoD _dependencia;

        public ITipoD Dependencia
        {
            get { return _dependencia; }
            set { _dependencia = value; }
        }

        public TipoC(ITipoD dependencia)
        {
            _dependencia = dependencia;
        }
    }
}
