using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.DataService.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        public void CreateCustomer(Customers cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetAllUsers()
        {
            var Customer = new List<Customers>
            {
                new Customers { Id = 1, FirstName = "Ann", LastName = "Tom", Phone = 725965360 },
                new Customers { Id = 2, FirstName = "Sheetal", LastName = "Davis", Phone = 825965360 },
                new Customers { Id = 3, FirstName = "Ann", LastName = "Mathew", Phone = 995965360 }
             };
            return Customer;
        }

        public Customers GetCustomersById(int id)
        {
            return new Customers {Id = 1, FirstName = "Ann", LastName = "Tom", Phone = 725965360 };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customers cmd)
        {
            throw new NotImplementedException();
        }
    }
}
