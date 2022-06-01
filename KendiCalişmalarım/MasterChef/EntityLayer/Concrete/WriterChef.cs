using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterChef
    {
        public int WriterChefId { get; set; }
        public string WriterChefName { get; set; }
        public string WriterChefAbout { get; set; }
        public string WriterChefImage { get; set; }
        public string WriterChefMail { get; set; }
        public string WriterChefPassword { get; set; }
        public bool WriterChefStatus { get; set; }

        //public List<Food> Foods { get; set; }
    }
}

