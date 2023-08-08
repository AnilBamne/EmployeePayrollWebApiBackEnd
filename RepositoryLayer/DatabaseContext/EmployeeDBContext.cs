using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<EmployeeEntity> EmployeeTable { get; set; }
    }
}
