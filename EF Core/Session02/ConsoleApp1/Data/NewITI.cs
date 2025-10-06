using ConsoleApp1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server= DESKTOP-BARKJTV\\MSSQLDEV22 ; Database= NewITI ;Trusted_Connection=True ; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Stu_Crs> Stu_Crs { get; set; }
    }
}
