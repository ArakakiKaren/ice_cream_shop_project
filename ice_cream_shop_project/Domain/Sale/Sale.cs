using ice_cream_shop_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ice_cream_shop_project.Domain.Sale
{
    public class Sale
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? SoldAt { get; set; }
        public ESaleStatus SoldAt { get; set; }
        public Collection<SaleItem> Items { get; set; }
        public decimal Total { get; set; }
        public Payment? Payment { get; set; }
    }
}
