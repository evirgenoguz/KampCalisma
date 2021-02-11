using GameProject.Nesneler;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Id = 1;
            oyuncu1.Adi = "Oğuz";
            oyuncu1.Soyadi = "Evirgen";
            oyuncu1.DogumTarihi = new DateTime(1998, 01, 22);
            oyuncu1.TcKimlikNo = "13895763530";
            //oyuncumuzu oluşturduk bunun bir kaç farklı yolu vardır mutlaka constructor gibi olabilir, ya da new Oyuncu dan sonra {} şeklinde devam edilebilir.

            Oyun oyun1 = new Oyun { OyunAdi = "Cyberpunk 2077", OyunFiyati = 249, OyunAdet = 100 };
            //oyun1 nesnesini Oyun sınıfından oluşturduk.

            Kampanya kampanya1 = new Kampanya { KampanyaAdi = "TeknoPazar", indirimOrani = 15}; //Teknopazar da oyunlar için %15 indirim var

            OyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.Ekle();
            
        }
    }
}