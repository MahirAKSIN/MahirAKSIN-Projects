using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstCodeLibraryy.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public string BookDetailIsbn { get; set; }
        public string BookDetailCity { get; set; }
        public string BookDetailCountry { get; set; }
        public DateTime BookDetailYear{ get; set; }


    }
}
