using System;
using System.Collections.Generic;
using System.Text;
using Bake.DataService.Models;

namespace Bake.DataService.Repositories
{
    public interface ICustomerRepo
    {
        bool SaveChanges();
        IEnumerable<Customers> GetAllUsers();
        Customers GetCustomersById(int id);
        void CreateCustomer(Customers cmd);
        void UpdateCustomer(Customers cmd);
    }
}
