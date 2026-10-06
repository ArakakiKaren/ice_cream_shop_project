using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class UnitProduct : Product
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
