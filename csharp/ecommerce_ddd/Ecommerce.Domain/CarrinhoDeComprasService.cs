using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Domain
{
    public class CarrinhoDeComprasService
    {
        private IProdutoRepository _produtoRepository;

        public CarrinhoDeComprasService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            return _produtoRepository.GetAll();
        }
    }
}
