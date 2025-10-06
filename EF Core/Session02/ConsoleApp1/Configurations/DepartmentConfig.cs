using ConsoleApp1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(nameof(Department.DepartmentId));
            builder.Property(builder => builder.DepartmentId).ValueGeneratedOnAdd();
            builder.Property(builder => builder.DepartmentName).HasMaxLength(50)
                                                                .IsRequired();
            builder.Property(builder => builder.HiringDate).IsRequired();

            builder.HasOne(m => m.Manager)
                   .WithOne(d => d.ManagedDepartment)
                   .HasForeignKey<Department>(d => d.ManagerId)
                   .IsRequired();
        }
    }
}
