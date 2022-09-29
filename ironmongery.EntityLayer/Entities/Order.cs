using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironmongery.EntityLayer.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderCustomerID { get; set; }
        public int OrderProductID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderDescription { get; set; }
    }
}
