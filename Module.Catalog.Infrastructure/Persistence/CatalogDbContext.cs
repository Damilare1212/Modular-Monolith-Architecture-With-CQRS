﻿using Microsoft.EntityFrameworkCore;
using Module.Catalog.Core.Abstractions;
using Module.Catalog.Core.Entities;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Catalog.Infrastructure.Persistence
{
    public class CatalogDbContext : ModuleDbContext, ICatalogDbContext
    {

        protected override string Schema => "Catalog";
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
