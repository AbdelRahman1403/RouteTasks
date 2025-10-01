using Microsoft.EntityFrameworkCore;
using Session01.Data.Models;

namespace Session01.Data
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string oldConnectionString = "Data Source= . ;Initial Catalog= databaseName ;Integrated Security=True";
            string connectionString = "Server= DESKTOP-BARKJTV\\MSSQLDEV22 ; Database= NewComapany ;Trusted_Connection=True ; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Class Employee 
            //string name ---> ???  varchar(max) , nvarchar 
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
