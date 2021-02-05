using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bake.DataService.Repositories
{
    class SqlRDishesRepo : IRegDishes
    {
        private readonly BakeDbContext _context;
        public SqlRDishesRepo(BakeDbContext context)
        {
            _context = context;
        }
        public void CreateRDishes(RDishes rDishes)
        {
            if (rDishes == null)
            {
                throw new ArgumentNullException(nameof(rDishes));
            }
            _context.RDishes.Add(rDishes);
        }

        public IEnumerable<RDishes> GetAllRDishes()
        {
            return _context.RDishes.ToList();
        }

        public RDishes GetRDishesById(int id)
        {
            return _context.RDishes.FirstOrDefault(p => p.RDishesID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void DeleteRDishes(RDishes rDishes)
        {
            if (rDishes == null)
            {
                throw new ArgumentNullException(nameof(rDishes));
            }
            _context.RDishes.Remove(rDishes);
        }

        
    }
}
