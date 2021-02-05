using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bake.DataService.Repositories
{
    class SqlOrderRepo:IOrderRepo
    {
        private readonly BakeDbContext _context;

        public SqlOrderRepo(BakeDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(Orders Order)
        {
            if (Order == null)
            {
                throw new ArgumentNullException(nameof(Order));
            }
            _context.Orders.Add(Order);
        }

        public void DeleteOrder(Orders Order)
        {
            if (Order == null)
            {
                throw new ArgumentNullException(nameof(Order));
            }
            _context.Orders.Remove(Order);
        }

        public IEnumerable<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Orders GetOrdersById(int id)
        {
            return _context.Orders.FirstOrDefault(p => p.OrdersID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

       

        public void UpdateOrder(Orders Order)
        {
            
        }
    }
}
