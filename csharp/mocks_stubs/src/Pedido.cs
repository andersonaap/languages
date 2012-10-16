using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocks_stubs
{
    public class Pedido
    {
        private const string MensagemPedidoNaoPreenchido = "Pedido não preenchido.";

        private IEmailService _emailService;
        private int _quantidade;
        private bool _preenchido;
        private string _produto;


        public Pedido(string produto, int quantidade)
        {
            _preenchido = false;
            _produto = produto;
            _quantidade = quantidade;
        }

        public void DefinirEmailService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public bool EstaPreenchido()
        {
            return _preenchido;
        }

        public void Preencher(IEstoque estoque)
        {
            if (estoque.TemDisponibilidade(_produto, _quantidade))
            {
                estoque.Retirar(_produto, _quantidade);
                _preenchido = true;
            }
            else 
            {
                if (_emailService != null)
                    _emailService.Enviar(MensagemPedidoNaoPreenchido);
            }
        }
    }
}
