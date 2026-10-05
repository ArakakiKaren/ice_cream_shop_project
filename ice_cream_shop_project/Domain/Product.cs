using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public ETypeProduct Type { get; set; }
        public string? Description { get; set; }
        public double SubTotal { get; set; }
    }
}
