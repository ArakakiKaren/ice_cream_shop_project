using ice_cream_shop_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public EExpenseCategory Category { get; set; }
        public DateTime Date {  get; set; }
        public DateTime PaidAt { get; set; }
        public EExpenseStatus Status { get; set; }


    }
}
