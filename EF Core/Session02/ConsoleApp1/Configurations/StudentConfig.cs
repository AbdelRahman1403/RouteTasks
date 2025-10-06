using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConsoleApp1.Data.Models;

namespace ConsoleApp1.Configurations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students", "dbo");
            builder.HasKey(nameof(Student.StuID));
            builder.Property(nameof(Student.StuID)).ValueGeneratedOnAdd();
            builder.Property(nameof(Student.FName)).HasMaxLength(50)
                                                   .HasColumnName("FirstName")
                                                   .IsRequired();
            builder.Property(nameof(Student.LName)).HasMaxLength(50)
                                                   .HasColumnName("LastName");

            builder.Property(nameof(Student.Address)).HasMaxLength(50);
            builder.Property(nameof(Student.Age)).IsRequired();
            builder.Property(nameof(Student.DeptID)).IsRequired();

            builder.HasOne(s => s.department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(f => f.DeptID)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
