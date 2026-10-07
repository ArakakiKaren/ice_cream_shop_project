using ice_cream_shop_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ETypeProduct Type { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
    }
}
