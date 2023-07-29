using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Acme_Corp.Models.Database
{

    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Order> Orders { get; set; }

        // DbContext configuration and connection string setup
    }
}

