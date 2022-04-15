using System;
using System.Collections.Generic;

#nullable disable

namespace Kutuphane.Models
{
    public partial class Odunc
    {
        public int Id { get; set; }
        public int? UyeId { get; set; }
        public string KitapIsbn { get; set; }
        public DateTime? VerilisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool? Iptal { get; set; }

        public virtual Kitaplar KitapIsbnNavigation { get; set; }
        public virtual Uyeler Uye { get; set; }
    }
}
