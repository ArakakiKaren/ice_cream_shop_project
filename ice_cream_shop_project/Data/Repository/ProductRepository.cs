using ice_cream_shop_project.Data.Context;
using ice_cream_shop_project.Domain;
using ice_cream_shop_project.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;


namespace ice_cream_shop_project.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            IceCreamShopContext.Set<Product>().Add(product);
        }
    }
}
