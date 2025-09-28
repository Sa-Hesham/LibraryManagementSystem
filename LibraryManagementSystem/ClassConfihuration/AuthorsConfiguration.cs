using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ClassConfihuration
{
    internal class AuthorsConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");

            builder.Property(A => A.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(20);


            builder.Property(A => A.LastNsme)
              .HasColumnType("varchar")
              .HasMaxLength(20);



            builder.Property(A => A.Id)
                .HasColumnName("AauthorId" );
        }
    }
}
