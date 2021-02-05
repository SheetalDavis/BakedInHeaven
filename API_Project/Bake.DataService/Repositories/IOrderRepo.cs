using System;
using System.Collections.Generic;
using System.Text;
using Bake.DataService.Models;

namespace Bake.DataService.Repositories
{
    public interface IOrderRepo
    {
        bool SaveChanges();
        IEnumerable<Orders> GetAllOrders();
        Orders GetOrdersById(int id);
        void CreateOrder(Orders Order);
        void UpdateOrder(Orders Order);
        void DeleteOrder(Orders Order);
    }
}
