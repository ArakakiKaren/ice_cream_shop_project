using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain.Sale
{
    public class UnitSaleItem : SaleItem
    {
        public int Quantity { get; set; }
        public override decimal SubTotal => Quantity * UnitPrice;
    }
}
