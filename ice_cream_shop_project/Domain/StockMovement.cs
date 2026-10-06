using ice_cream_shop_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class StockMovement
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public EStockMovementType StockMovementType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Description { get; set; }
    }
}
