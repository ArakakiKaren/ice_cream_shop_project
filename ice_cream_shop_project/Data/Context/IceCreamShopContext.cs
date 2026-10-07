using ice_cream_shop_project.Domain;
using ice_cream_shop_project.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Data.Context
{
    public class IceCreamShopContext : DbContext, IIceCreamShopContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
