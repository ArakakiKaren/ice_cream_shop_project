using ice_cream_shop_project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISharedDbContext _context;
        public IProductRepository ProductRepository { get; set; }

        public UnitOfWork(ISharedDbContext context)
        {
            _context = context;
            ProductRepository = new ProductRepository;
        }
    }
}
