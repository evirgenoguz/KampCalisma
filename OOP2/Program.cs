using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Oguz";
            musteri1.Soyadi = "Evirgen";
            musteri1.TcNo = "11111122222";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1232";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234577990";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            //Gerçek Müsteri - Tüzel Müşteri
            //SOLID
        }
    }
}
