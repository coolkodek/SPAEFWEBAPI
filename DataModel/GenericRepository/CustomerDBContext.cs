using POCOModels.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace DataModel.GenericRepository
{
    public class CustomerDBContext : DbContext
    {

        public CustomerDBContext()
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public DbSet<Customer> Customers { get; set; }
    }
}
