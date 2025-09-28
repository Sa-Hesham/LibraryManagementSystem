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
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {

            builder.ToTable("Lonas");


            builder.Property(l => l.Id)
                .HasColumnName("LoanId");


            builder.Property(l => l.LoanDate)
                .HasDefaultValueSql("GETDATE()");


            builder.Property(l => l.Status)
                .HasConversion<string>()
                .HasMaxLength(9)
                .IsRequired();

            

        }
    }
}
