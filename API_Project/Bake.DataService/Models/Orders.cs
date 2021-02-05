using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.DataService.Models
{
    public class Orders
    {
        public int OrdersID { get; set; }
        public DateTime date { get; set; }
        public int customerID { get; set; }

    }
}
