using Microsoft.EntityFrameworkCore;
using Petzey.Dept.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Dept.Data
{
    public class DeptDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("postgres://optadmin:password@123@opeatmix-petzey.postgres.database.azure.com/postgres?sslmode=require");
            //optionsBuilder.
            optionsBuilder.UseNpgsql("Server=opeatmix-petzey.postgres.database.azure.com;Database=opt-department;Port=5432;User Id=optadmin;Password=password@123;Ssl Mode=VerifyCA;");
        }
        public DbSet<Department> Departments { get; set; }
        
    }
}
