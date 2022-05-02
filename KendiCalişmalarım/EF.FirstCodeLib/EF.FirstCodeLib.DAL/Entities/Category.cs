using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.FirstCodeLib.DAL.Entities
{
 public   class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescrition { get; set; }


        public List<Book> Books { get; set; }
    }
}
