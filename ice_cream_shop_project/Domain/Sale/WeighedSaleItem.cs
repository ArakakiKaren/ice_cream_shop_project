using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain.Sale
{
    public class WeighedSaleItem : SaleItem
    {
        public decimal Weight { get; set; }
        public decimal PricePerWeight { get; set; }

        public override decimal SubTotal => PricePerWeight * Weight;
    }
}
