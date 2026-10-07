using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain.Interfaces
{
    public interface IIceCreamShopContext
    {
        DbSet<Product> Product { get; set; }
    }
}
