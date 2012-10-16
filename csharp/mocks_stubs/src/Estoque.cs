using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocks_stubs
{
    public class Estoque : IEstoque
    {
        private Dictionary<string, int> _produtos = new Dictionary<string, int>();
        

        public void Incluir(string produto, int quantidade)
        {
            if (_produtos.ContainsKey(produto))
                _produtos[produto] += quantidade;
            else
                _produtos[produto] = quantidade;
        }

        public int ObterDisponibilidade(string item)
        {
            return _produtos[item];
        }

        public void Retirar(string produto, int quantidade)
        {
            _produtos[produto] -= quantidade;
        }

        public bool TemDisponibilidade(string produto, int quantidade)
        {
            if (!_produtos.ContainsKey(produto))
                return false;
            else if (_produtos[produto] < quantidade)
                return false;
            else
                return true;
        }
    }
}
