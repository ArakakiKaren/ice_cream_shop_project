using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain.Sale
{
    public abstract class SaleItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public abstract decimal SubTotal { get; }
    }
}
