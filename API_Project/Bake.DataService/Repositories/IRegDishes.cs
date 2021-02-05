using System;
using System.Collections.Generic;
using System.Text;
using Bake.DataService.Models;

namespace Bake.DataService.Repositories
{
    public interface IRegDishes
    {
        bool SaveChanges();
        IEnumerable<RDishes> GetAllRDishes();
        RDishes GetRDishesById(int id);
        void CreateRDishes(RDishes rDishes);
        void DeleteRDishes(RDishes rDishes);
    }
}
