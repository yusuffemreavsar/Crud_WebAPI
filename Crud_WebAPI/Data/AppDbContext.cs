﻿using Microsoft.EntityFrameworkCore;

namespace Crud_WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }  

    }
}
