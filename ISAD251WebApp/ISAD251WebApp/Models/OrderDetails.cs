using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAD251WebApp.Models
{
        public partial class OrderDetails
        {
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal? LineTotal { get; set; }

            public virtual Products Product { get; set; }
        }
    }
}
