﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Context
{
    class TesteNavaDbContext : DbContext
    {
        public  TesteNavaDbContext(DbContextOptions options) : base(options){ }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TesteNavaDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
