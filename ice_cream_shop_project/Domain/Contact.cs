using ice_cream_shop_project.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ice_cream_shop_project.Domain
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public EContactType Type { get; set; }
        public string? Phone {  get; set; }
        public string? Email { get; set; }
        public string? Registry { get; set; }
        public string? Notes { get; set; }
        public bool Active { get; set; }
    }
}
