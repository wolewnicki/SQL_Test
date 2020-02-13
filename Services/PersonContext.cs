using System;
using Npgsql.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SQL_Test.Models;

namespace SQL_Test.Services
{
    public class PersonContext: DbContext
    {
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=postgres:5432;Database=test_db;Username=test;Password=password");
    }
}

