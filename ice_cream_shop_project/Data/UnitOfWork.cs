using ice_cream_shop_project.Data.Repository;
using ice_cream_shop_project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IIceCreamShopContext _context;
        public IProductRepository ProductRepository { get; }

        public UnitOfWork(IIceCreamShopContext context)
        {
            _context = context;
            ProductRepository = new ProductRepository(_context);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
