using LibraryManagementSystem.Models.AttributesEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Member :Base
    {

        public string Name { get; set; } = null!;


        public string Email{ get; set; } = null!;


        public string PhoneNumber { get; set; } = null!;




     
        public string Adress { get; set; } = null!;


        public  DateTime MembershipDate { get; set; }



        public MemberStatus Status { get; set; }













    }
}
