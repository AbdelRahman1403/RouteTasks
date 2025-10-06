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
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses" , "dbo");
            builder.HasKey(builder => builder.Crs_Id);
            builder.Property(builder => builder.Crs_Id).ValueGeneratedOnAdd();

            builder.Property(builder => builder.Crs_Name).HasMaxLength(50)
                                                         .HasColumnName("CourseName")
                                                         .IsRequired();
            builder.Property(builder => builder.Crs_Duration).IsRequired();
            builder.Property(builder => builder.Crs_Description);
            builder.HasMany(t => t.Topics)
                   .WithOne(c => c.crs)
                   .HasForeignKey(c => c.Crs_Id)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
            //builder.ToTable("Courses" , "dbo");
            //builder.HasKey(builder => builder.Crs_Id);
            //builder.Property(builder => builder.Crs_Id).ValueGeneratedOnAdd();
            //builder.Property(builder => builder.Crs_Name).HasMaxLength(50)
            //                                             .HasColumnName("CourseName")
            //                                             .IsRequired();
            //builder.Property(builder => builder.Crs_Duration).IsRequired();
            //builder.Property(builder => builder.Crs_Description);
            ////builder.Property(builder => builder.TopicId).IsRequired();
            //builder.HasMany(c => c.Topics)
            //        .WithOne(t => t.crs) // Now WithOne has the navigation property
            //        .HasForeignKey(t => t.Crs_Id);
        }
    }
}
