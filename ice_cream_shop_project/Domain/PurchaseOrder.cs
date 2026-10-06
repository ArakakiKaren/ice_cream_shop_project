using ice_cream_shop_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class PurchaseOrder
    {
        public Guid Id { get; set; }
        public Contact Supplier { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ReceivedAt { get; set; }
        public EPurchaseOrderStatus Status { get; set; }
        public Collection<PurchaseOrderItem> Items { get; set; }
        public decimal Total { get; set; }
    }
}
