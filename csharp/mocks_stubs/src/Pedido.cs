using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocks_stubs
{
    public class Pedido
    {
        private string _produto;
        private int _quantidade;
        private bool _preenchido;


        public Pedido(string produto, int quantidade)
        {
            _preenchido = false;
            _produto = produto;
            _quantidade = quantidade;
        }

        public bool EstaPreenchido()
        {
            return _preenchido;
        }

        public void Preencher(IEstoque estoque)
        {
            if(estoque.TemDisponibilidade(_produto,_quantidade))
            {
                estoque.Retirar(_produto, _quantidade);
                _preenchido = true;
            }
        }
    }
}
