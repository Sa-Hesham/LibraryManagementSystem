using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Category:Base
    {

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;



        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
