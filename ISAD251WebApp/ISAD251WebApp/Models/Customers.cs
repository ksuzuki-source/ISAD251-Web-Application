using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAD251WebApp.Models
{
    public class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int ID { get; set; }

        public int TableId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }

}
