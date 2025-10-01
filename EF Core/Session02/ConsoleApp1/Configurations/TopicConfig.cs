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
    internal class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics", "dbo");
            builder.HasKey(builder => builder.Topic_ID);
            builder.Property(builder => builder.Topic_ID).ValueGeneratedOnAdd();
            builder.Property(builder => builder.Topic_Name).HasMaxLength(50)
                                                          .HasColumnName("TopicName")
                                                          .IsRequired();
        }
    }
}
