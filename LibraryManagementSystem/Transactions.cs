using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.AttributesEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class Transactions
    {

        public static void Borrowbook (LibraryDbcontext db , int MemberId , int BookId , int Days )
        {

            var Member = db.Set<Member>().SingleOrDefault(m=>m.Id==MemberId);
            var Book = db.Set<Book>().Find(BookId);

            if (Member == null || Book == null)
            {

                Console.WriteLine("member  or book not Found ");
                return;
            }
          

            if (Book.AvailableCopies <= 0)
            {
                Console.WriteLine("book not abilable");
            }



            var Loan = new Loan()
            {

                LoanDate = DateTime.Now,
                Status = LoanStatus.Borrowed,

            };


            db.Set<Loan>().Add(Loan);
            db.SaveChanges();


            var MembersLoans = new MemberLoans()
            {
                BookId = BookId,
                MemberId = MemberId,
                LoanId = Loan.Id,
                ReturnDate = null,
                DueDate = DateTime.Now.AddDays(5),

            };

            db.Set<MemberLoans>().Add(MembersLoans);
          



            Book.AvailableCopies--;


            db.SaveChanges();

        }




        public static void ReturnBook (LibraryDbcontext db  , int bookId , int memberId , int daysfterreturn)
        {

            var MemebrLoan = db.Set<MemberLoans>().FirstOrDefault(m => m.MemberId == memberId && m.BookId == bookId);
            if (MemebrLoan == null) {

                Console.WriteLine("Not Found");
                return;
            
            }

            MemebrLoan.ReturnDate=DateTime.Now.AddDays(daysfterreturn);
            db.SaveChanges ();


            // increase the the borweed book 

            var borwwoedBook = db.Set<Book>().Find(bookId);


            
          
            borwwoedBook!.AvailableCopies++;


            // retrive laon to change status
            var loan = db.Set<Loan>().FirstOrDefault(l => l.Id == MemebrLoan.LoanId);

            //cheak if Duedate is equal date  to make Fine 
            if (MemebrLoan.DueDate <= MemebrLoan.ReturnDate)
            {
               loan!.Status =LoanStatus.Returned;
            }
            else
            {
                loan!.Status = LoanStatus.Overdue;

                var fine =  new Fine() { 
                
                Amount =20,
                IssuedDate = MemebrLoan?.ReturnDate??DateTime.Now.AddDays(daysfterreturn),
                LoandId=loan.Id,
                Status=FineStatus.Pending,
                
                
                
                };

                db.Set<Fine>().Add(fine);

                

            }

           




            db.SaveChanges();





        }


    }
}
