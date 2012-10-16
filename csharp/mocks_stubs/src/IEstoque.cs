using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocks_stubs
{
    public interface IEstoque
    {
        void Incluir(string produto, int quantidade);
        int ObterDisponibilidade(string produto);
        void Retirar(string produto, int quantidade);
        bool TemDisponibilidade(string produto, int quantidade);
    }
}
