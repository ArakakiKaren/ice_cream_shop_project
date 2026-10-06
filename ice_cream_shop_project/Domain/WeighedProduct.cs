using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class WeighedProduct :  Product
    {
        public decimal StockWeight { get; set; }
        public decimal PricePerWeight { get; set; }
    }
}
