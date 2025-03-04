using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04032025B
{
    internal class Ogrenci
    {
        public int numara { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public string Yaz()
        {
            string deger = "Numara : " + numara + "\n"
                           + "Ad : " + ad + "\n"
                           + "Soyad : " + soyad;
            return deger;
        }
    }
}
