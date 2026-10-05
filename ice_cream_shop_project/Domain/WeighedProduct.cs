using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class WeighedProduct :  Product
    {
        public double Weight { get; set; }
        public double PricePerWeight { get; set; }
    }
}
