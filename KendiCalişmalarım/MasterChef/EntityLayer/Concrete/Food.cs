using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodTitle { get; set; }
        public string FoodContent { get; set; }
        public string FoodThumbnailImage { get; set; }
        public string FoodImage { get; set; }
        public DateTime FoodCreateDate { get; set; }
        public bool FoodStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comment { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }

        //public int WriterChefId { get; set; }
        //public WriterChef WriterChef { get; set; }

    }
}
