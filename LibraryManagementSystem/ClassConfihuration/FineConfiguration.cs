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
    internal class FineConfiguration : IEntityTypeConfiguration<Fine>
    {
        public void Configure(EntityTypeBuilder<Fine> builder)
        {
            builder.ToTable("Fines");

            builder.Property(F => F.Amount)
                .HasPrecision(6, 2);


            builder.Property(F => F.IssuedDate)
                .HasDefaultValueSql("GETDATE()");



            builder.Property(F => F.Status)
                .HasConversion<string>()
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(F => F.PaidDate)
                .IsRequired(false);
        }
    }
}
