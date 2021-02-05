using Bake.DataService.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Bake.DataService.Repositories
{
    class SqlCustomerRepo : ICustomerRepo
    {
        private readonly BakeDbContext _context;

        public SqlCustomerRepo (BakeDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customers cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Customers.Add(cmd);
        }

        public IEnumerable<Customers> GetAllUsers()
        {
            return _context.Customers.ToList();
        }

        public Customers GetCustomersById(int id)
        {
            return _context.Customers.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges() >=0);
        }

        public void UpdateCustomer(Customers cmd)
        {
            throw new NotImplementedException();
        }
    }
}
