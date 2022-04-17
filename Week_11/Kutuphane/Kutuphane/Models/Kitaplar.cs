using System;
using System.Collections.Generic;

#nullable disable

namespace Kutuphane.Models
{
    public partial class Kitaplar
    {
        public Kitaplar()
        {
            Oduncs = new HashSet<Odunc>();
        }

        public string Isbn { get; set; }
        public string Ad { get; set; }
        public int? SayfaSayisi { get; set; }
        public int? Stok { get; set; }
        public int? TurId { get; set; }
        public int? YazarId { get; set; }
        public int? YayinEviId { get; set; }

        public virtual Turler Tur { get; set; }
        public virtual Yayinevleri YayinEvi { get; set; }
        public virtual Yazarlar Yazar { get; set; }
        public virtual ICollection<Odunc> Oduncs { get; set; }
    }
}
