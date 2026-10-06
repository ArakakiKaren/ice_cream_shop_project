using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class PurchaseOrderItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitCost { get; set; }
        public decimal SubTotal => Amount * UnitCost;
    }
}
