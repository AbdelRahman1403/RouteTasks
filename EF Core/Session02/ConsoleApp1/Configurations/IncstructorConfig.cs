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
    internal class IncstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors", "dbo");
            builder.HasKey(nameof(Instructor.InstructorId));
            builder.Property(nameof(Instructor.InstructorId)).ValueGeneratedOnAdd();
            builder.Property(nameof(Instructor.InstructorName)).HasMaxLength(50)
                                                   .HasColumnName("FirstName")
                                                   .IsRequired();
            builder.Property(nameof(Instructor.Address)).HasMaxLength(50);
            builder.Property(nameof(Instructor.Salary)).IsRequired();
            builder.Property(nameof(Instructor.Bonus));

            builder.HasOne(i => i.dept)
                    .WithMany(d=>d.Instructors)
                    .HasForeignKey(i => i.DeptId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
