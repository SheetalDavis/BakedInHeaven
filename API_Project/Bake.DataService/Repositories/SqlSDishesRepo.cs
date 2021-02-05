using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bake.DataService.Repositories
{
    class SqlSDishesRepo : ISpclDishRepo
    {
        private readonly BakeDbContext _context;
        public SqlSDishesRepo(BakeDbContext context)
        {
            _context = context;
        }
        public void CreateSDishes(SDishes sDishes)
        {
            if (sDishes == null)
            {
                throw new ArgumentNullException(nameof(sDishes));
            }
            _context.SDishes.Add(sDishes);
        }

        public IEnumerable<SDishes> GetAllSDishes()
        {
            return _context.SDishes.ToList();
        }

        public SDishes GetSDishesById(int id)
        {
            return _context.SDishes.FirstOrDefault(p => p.SDishesID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void DeleteSDishes(SDishes sDishes)
        {
            if (sDishes == null)
            {
                throw new ArgumentNullException(nameof(sDishes));
            }
            _context.SDishes.Remove(sDishes);
        }
    }
}
