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
    internal class MemberLoansConfihuration : IEntityTypeConfiguration<MemberLoans>
    {
        public void Configure(EntityTypeBuilder<MemberLoans> builder)
        {

           

            builder.HasOne(ml => ml.books)
                 .WithMany(B => B.MemberLoans)
                 .HasForeignKey(ml=>ml.BookId);



            builder.HasOne(ml => ml.Members)
                .WithMany(me => me.MemberLoans)
                .HasForeignKey(ml=>ml.MemberId);



            builder.HasOne(ml => ml.Loan)
                    .WithOne(l => l.Member)
                    .HasForeignKey<MemberLoans>(ml => ml.LoanId);



            builder.HasKey(ml => new { ml.LoanId, ml.BookId, ml.MemberId});
                   


           




        }
    }
}
