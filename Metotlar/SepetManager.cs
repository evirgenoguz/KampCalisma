using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Product urun)
        {
            Console.WriteLine(urun.Adi + " Sepete Eklendi");

        }
        public void Ekle2(string urunAdi, string aciiklama, double fiyat)
        {
            Console.WriteLine(urunAdi + " Sepete Eklendi");
        }
    }
}
