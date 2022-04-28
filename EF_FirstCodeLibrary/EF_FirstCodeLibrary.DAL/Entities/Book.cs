using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstCodeLibraryy.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string  BookName { get; set; }
        public decimal   BookPrice { get; set; }
        public DateTime   BookCreateDate { get; set; }

        public int? CategoryId{ get; set; }
        public Category Category{ get; set; }

    }
}
