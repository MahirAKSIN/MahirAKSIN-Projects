using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.FirstCodeLib.DAL.Entities
{
  public  class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public DateTime BookCreateDate { get; set; }
        public string  BookImage { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        //public BookDetail BookDetail { get; set; }
        //public object BookAuthors { get; internal set; }


        public List<BookAuthor> BookAuthors { get; set; }
        public BookDetail BookDetail { get; set; }
    }
}
