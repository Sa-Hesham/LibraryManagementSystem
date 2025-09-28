using LibraryManagementSystem.Models.AttributesEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Loan:Base
    {
        public DateTime LoanDate {  get; set; }
        public LoanStatus Status { get; set; }
    }
}
