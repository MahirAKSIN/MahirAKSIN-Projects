using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_002.Models
{
    public partial class Bolumler
    {
        public Bolumler()
        {
            Doktorlars = new HashSet<Doktorlar>();
        }

        public int Id { get; set; }
        public string BolumAd { get; set; }

        public virtual ICollection<Doktorlar> Doktorlars { get; set; }
    }
}
