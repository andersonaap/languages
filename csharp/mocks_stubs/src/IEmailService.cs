using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocks_stubs
{
    public interface IEmailService
    {
        void Enviar(string mensagem);
        int QuantidadeEnviada();
    }
}
