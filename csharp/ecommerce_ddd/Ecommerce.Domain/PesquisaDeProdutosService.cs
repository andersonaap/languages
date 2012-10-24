using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Domain
{
    public class PesquisaDeProdutosService
    {
        private IProdutoRepository _produtoRepository;

        public PesquisaDeProdutosService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            return _produtoRepository.GetAll();
        }
    }
}
