using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstCodeLibraryy.Entities
{
    public class Author
    {

        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }

        public string AuthorFullName => string.Concat(AuthorFirstName + "" + AuthorLastName);
        public DateTime AuthorCreateDate { get; set; }

        //1-Entities
        //2-Relations
        //3-DbContext
        //4-Config
        //5-Migrations
    }
}
