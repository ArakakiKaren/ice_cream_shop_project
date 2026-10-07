using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
    }
}
