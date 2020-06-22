using LinkedInData.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedInData.Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
