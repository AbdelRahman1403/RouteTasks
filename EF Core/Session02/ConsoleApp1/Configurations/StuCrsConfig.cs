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
    internal class StuCrsConfig : IEntityTypeConfiguration<Stu_Crs>
    {
        public void Configure(EntityTypeBuilder<Stu_Crs> builder)
        {
            builder.HasKey(builder => new { builder.Crs_ID, builder.Stu_ID });

            builder.HasOne(s => s.student)
                   .WithMany(sc => sc.StudentCourses)
                   .HasForeignKey(s => s.Stu_ID)
                   .IsRequired();
            builder.HasOne(c => c.course)
                    .WithMany(sc => sc.StudentCourses)
                    .HasForeignKey(c => c.Crs_ID)
                    .IsRequired();

            builder.Property(nameof(Stu_Crs.Grade)).IsRequired();
        }
    }
}
