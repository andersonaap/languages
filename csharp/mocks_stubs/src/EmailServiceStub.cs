using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocks_stubs
{
    public class EmailServiceStub : IEmailService
    {
        private IList<string> _mensagens = new List<string>();

        public void Enviar(string mensagem)
        {
            _mensagens.Add(mensagem);
        }
        
        public int QuantidadeEnviada()
        {
            return _mensagens.Count;
        }
    }
}
