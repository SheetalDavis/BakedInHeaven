using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class OrderCreateDto
    {
        public int OrdersID { get; set; }
        public DateTime date { get; set; }
        public int customerID { get; set; }

    }
}
