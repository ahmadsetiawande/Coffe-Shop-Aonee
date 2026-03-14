using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.Models
{
    public class ItemStock
    {
        public int IdItem { get; set; }
        public string Code { get; set; } = string.Empty;
        public string? Title { get; set; }
        public string? Measurement { get; set; }
        public double? Quantity { get; set; }
        public DateTime? LastUpadte { get; set; }
        public string? IsDeleted { get; set; }




    }
}
