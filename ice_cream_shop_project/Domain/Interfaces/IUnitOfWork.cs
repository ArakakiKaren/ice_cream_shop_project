using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        int Commit();
    }
}
