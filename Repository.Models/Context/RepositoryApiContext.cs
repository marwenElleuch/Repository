using Microsoft.EntityFrameworkCore;
using Repository.Models.Modes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models.Context
{
    public class RepositoryApiContext : DbContext
    {
        public RepositoryApiContext(DbContextOptions<RepositoryApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new StudentMap(modelBuilder.Entity<Student>());
        }
    }
}
