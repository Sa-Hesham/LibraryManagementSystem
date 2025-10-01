using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ClassConfihuration
{
    internal class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("Members", me =>
            {
                me.HasCheckConstraint("CheakEmail", "Email LIKE '%_@_%._%'");

                me.HasCheckConstraint("CheakPhoneNumber", "PhoneNumber LIke '01%' AND LEN(PhoneNumber) = 11");


            });

            builder.Property(m => m.Id)
                .HasColumnName("MemberId");


            builder.Property(m => m.Name)
                .HasColumnType("Varchar")
                .HasMaxLength(50);


            builder.Property(m => m.Address)
            .HasColumnType("Varchar")
            .HasMaxLength(50);


            builder.Property(m => m.MembershipDate)
                .HasDefaultValueSql("GETDATE()");


            builder.Property(m => m.Status)
                .HasConversion<string>()
                .HasMaxLength(10)
                .IsRequired();
               

        }
    }
}
