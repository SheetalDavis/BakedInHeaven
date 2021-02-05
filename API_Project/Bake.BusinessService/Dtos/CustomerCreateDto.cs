using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class CustomerCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        //public int Id { get; internal set; }
    }
}
