using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete
{
    public class ChangeCase
    {
        public string ConvertString(string text)
        {


            text = text.Replace("I", "i");
            text = text.Replace("İ", "i");
            text = text.Replace("ı", "i");
            text = text.ToLower();

            text = text.Replace("ç", "c");
            text = text.Replace("ö", "o");
            text = text.Replace("ş", "s");
            text = text.Replace("ğ", "g");
            text = text.Replace("ü", "u");



            return text;
        }

    }
}
