using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_002.Models
{
    public partial class Hastalar
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
    }
}
