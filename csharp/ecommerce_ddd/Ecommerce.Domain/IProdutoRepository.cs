﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Domain
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
    }
}
