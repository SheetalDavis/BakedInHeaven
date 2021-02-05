using System;
using System.Collections.Generic;
using System.Text;
using Bake.DataService.Models;
using Microsoft.EntityFrameworkCore;


namespace Bake.DataService
{
    public class BakeDbContext : DbContext
    {
        public BakeDbContext(DbContextOptions<BakeDbContext> opt) : base(opt)
        {

        }
        //private string ConnectionString = "Host=localhost;Database=BakeDb;Username=postgres;Password=S@1ntrita";

        public DbSet<Customers> Customers { get; set; }
        public DbSet<SDishes> SDishes { get; set; }
        public DbSet<RDishes> RDishes { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
