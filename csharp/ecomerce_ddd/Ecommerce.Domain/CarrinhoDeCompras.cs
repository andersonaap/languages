using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Domain
{
    public class CarrinhoDeCompras
    {
        private IProdutoRepository _produtoRepository;

        public CarrinhoDeCompras(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            return _produtoRepository.GetAll();
        }
    }
}
