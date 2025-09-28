using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Author :Base
    {

        public string FirstName { get; set; } = null!;
        public string LastNsme { get; set; } = null!;

        public DateTime BirthDate { get; set; } 


    }
}
