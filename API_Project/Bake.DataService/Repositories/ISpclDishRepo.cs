using System;
using System.Collections.Generic;
using System.Text;
using Bake.DataService.Models;

namespace Bake.DataService.Repositories
{
    public interface ISpclDishRepo
    {
        bool SaveChanges();
        IEnumerable<SDishes> GetAllSDishes();
        SDishes GetSDishesById(int id);
        void CreateSDishes(SDishes sDishes);
        void DeleteSDishes(SDishes sDishes);
    }
}
