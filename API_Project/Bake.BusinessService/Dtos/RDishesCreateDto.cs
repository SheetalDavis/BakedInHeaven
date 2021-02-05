using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class RDishesCreateDto
    {
        public int RDishesID { get; set; }
        public string tName { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int weight { get; set; }
        public int calories { get; set; }
        public bool type { get; set; }
    }
}
