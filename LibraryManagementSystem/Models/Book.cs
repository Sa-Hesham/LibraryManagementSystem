using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book :Base
    {

        public string Title { get; set; } = null!;
        public decimal Price { get; set; }

        public int PublicationYear { get; set; }


        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }



       
        public int AuthorId { get; set; }
        public Author Authors { get; set; } = null!;




        public int CatgeoryId { get; set; }

        public Category Category { get; set; } = null!;




        public  ICollection< MemberLoans>   MemberLoans { get; set; }=new List< MemberLoans>();




    }
}
