using LibraryManagementSystem.Models.AttributesEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Fine :Base
    {
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; }


        public DateTime ?PaidDate { get; set; }




        public  FineStatus Status { get; set; }



        public int LoandId { get; set; }
        public Loan Loan { get; set; } = null!;


    }
}
