using LibraryManagementSystem.Data;
using LibraryManagementSystem.DataSeeding;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.AttributesEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Tokens;
using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using LibraryDbcontext db =new LibraryDbcontext();
            #region DataSeeding

            //bool data = false;


            //try
            //{
            //    // data = SeedingData.seeding<Member>("Files/Members.json", db);
            //    // data = SeedingData.seeding<Category>("Files/Categories.json", db);
            //    // data = SeedingData.seeding<Author>("Files/Authors.json", db);
            //    data = SeedingData.seeding<Book>("Files/Books.json", db);

            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine(" File not found: " + ex.FileName);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error while seeding Airlines: {ex.Message}");



            //}


            //if (data)
            //{

            //    Console.WriteLine(" Airlines data saved successfully.");
            //}


            #endregion


            #region  Data manipulations



            #region  Retrieve the book title, its category title, and the author’s full name for all books whose price is greater than 300.
            // var book = from B in db.Set<Book>();
            //           join C in db.Set<Category>()
            //           on B.CatgeoryId equals C.Id
            //           join A in db.Set<Author>()
            //           on B.AuthorId equals A.Id
            //           where B.Price >300
            //           select new
            //           {

            //               BookTitle = B.Title,
            //               CategoryTitle = C.Title,
            //               AuthorName = A.FirstName + "" + A.LastNsme,




            //           };


            //foreach (var item in book)
            //{

            //    Console.WriteLine(item);

            //}

            #endregion



            #region  Retrieve All Authors And His / Her Books if Exists.

            //var AuthorsBooks = db.Set<Author>()
            //                    .Include(A => A.AuthorsBook)
            //                    .ToList();

            //foreach (var item in AuthorsBooks)
            //{
            //    Console.WriteLine($"Author name = {item.FirstName}  {item.LastNsme}");

            //    foreach (var book in item.AuthorsBook)
            //        Console.WriteLine($"BookName = {book.Title}");
            //}



            //var authors = from a in db.Set<Author>()
            //              join b in db.Set<Book>()
            //              on a.Id equals b.AuthorId into authorsbook
            //              from b in authorsbook.DefaultIfEmpty()
            //              select new
            //              {
            //                  AuthorName = $"{a.FirstName} {a.LastNsme}",
            //                  BookNAme = b == null ? "NoBook" : b.Title 

            //              };


            //foreach (var item in authors)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            #region MyRegionMember with id 1 Want To Borrow The Book With Id 2 And He Will Return it After 5 Days 

           // Transactions.Borrowbook(db, 1, 2, 5);


            #endregion


            #region After 10 Days Member with id 1 Returned The Book

            Transactions.ReturnBook(db, 1, 1, 10);

            #endregion



            #region Retrieve all members who currently have active loans (i.e., loans that have not yet been returned)

            //var result = from m in db.Set<Member>()
            //             join ml in db.Set<MemberLoans>()
            //             on m.Id equals ml.MemberId
            //             join l in db.Set<Loan>()
            //             on ml.LoanId equals l.Id
            //             where l.Status == LoanStatus.Borrowed
            //             select new
            //             {
            //                 Membername=m.Name,


                                     

            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Member: {item.Membername}");
            //}




            #endregion

            #endregion
        }
    }
}
