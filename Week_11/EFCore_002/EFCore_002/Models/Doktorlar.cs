using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_002.Models
{
    public partial class Doktorlar
    {
        public int Id { get; set; }
        public string SicilNo { get; set; }
        public string AdSoyad { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int BolumId { get; set; }

        public virtual Bolumler Bolum { get; set; }
    }
}
