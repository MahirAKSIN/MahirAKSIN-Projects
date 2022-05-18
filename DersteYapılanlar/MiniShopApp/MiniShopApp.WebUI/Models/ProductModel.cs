using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class ProductModel
    {

        public int ProductId { get; set; }
        //[Required(ErrorMessage = "Urum ismi zorunludur")]
        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Urun ismi 5 ile 50 arasında karakter olmalıdır")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        //[Range(1, 50000, ErrorMessage = "Lütfen 1-50000 arasında fiyat araalığı giriniz")]
        public decimal? Price { get; set; }
        //[Required(ErrorMessage = "Acıklama zorunludur")]
        //[StringLength(500, MinimumLength = 20, ErrorMessage = "Acıklama 20-500 arasında")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "Lürfen urun gorseli yolu giriniz")]
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
