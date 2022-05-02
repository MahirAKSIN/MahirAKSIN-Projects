using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.FirstCodeLib.DAL.Entities
{
 public   class BookDetail
    {
        public int BookDetailId { get; set; }
        public string BookDetailIsbn { get; set; }
        public string BookDetailCity { get; set; }
        public string BookDetailCountry { get; set; }
        public int BookDetailYear { get; set; }
        public Book Book{ get; set; }
        public int BookId { get; set; }

    }
}
