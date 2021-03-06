﻿using Exercise.EntityFramework.Examples.Model.Dependencies;
using System.Data.Entity;

namespace Exercise.EntityFramework.Examples.Migration
{
    public class SimpleContext : DbContext
    {
        public SimpleContext() 
            : base("SimpleContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
