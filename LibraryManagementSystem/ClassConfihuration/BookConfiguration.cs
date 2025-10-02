using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ClassConfihuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        void IEntityTypeConfiguration<Book>.Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(b =>
            {
                b.HasCheckConstraint("cheak_Book_PublicationYear", "PublicationYear BETWEEN 1950 AND YEAR(GETDATE())");

                b.HasCheckConstraint("check_Book_Copies","AvailableCopies <= TotalCopies");

            });


            builder.Property(b => b.Price)
                .HasPrecision(6, 2);


            builder.Property(b => b.Title)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(b => b.Id)
                .HasColumnName("BookId");


            //add relation between book and author 

            builder 
                .HasOne(B=>B.Authors)
                .WithMany(a=>a.AuthorsBook)
                .HasForeignKey(b=>b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict );



            //add relation between book and Category

            builder.HasOne(B=>B.Category)
                .WithMany(Cat=>Cat.Books)
                .HasForeignKey(B=>B.CatgeoryId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
