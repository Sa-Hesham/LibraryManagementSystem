using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ClassConfihuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(Cat => Cat.Title)
                     .HasColumnType("varchar")
                     .HasMaxLength(50);


            builder.Property(Cat => Cat.Description)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);


            builder.Property(Cat => Cat.Id)
                .HasColumnName("CategoryId");

        }
    }
}
