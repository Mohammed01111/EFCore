using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using OutsysCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsysCompany
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(" Data Source=DESKTOP-VFQRVL8\\MSSQLSERVER02; Initial Catalog=OutsystemCompany; Integrated Security=true; TrustServerCertificate=True ");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<WorksOn> worksOn { get; set; }
        public DbSet<DeptLocation> DeptLocations { get; set; }
    }
}
