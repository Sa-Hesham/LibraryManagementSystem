using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class MemberLoans
    {
        public DateTime DueDate { get; set; }
        public DateTime ? ReturnDate { get; set; }




        public int BookId {  get; set; }
        public Book books { get; set; } = null!;

        public int MemberId { get; set; }
        public Member Members { get; set; } = null!;


        public int LoanId { get; set; }
        public Loan Loan { get; set; } = null!;


    }
}
