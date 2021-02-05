using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class CustomerUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
    }
}
