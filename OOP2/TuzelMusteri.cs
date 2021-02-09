using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //Miras İnheritance Uyguladık Tüzel müşteri Musteri sınıfından miras aldı
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
