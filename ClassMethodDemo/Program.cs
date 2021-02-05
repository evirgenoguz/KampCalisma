using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //musteri nesnesi oluşturalım
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Ali";
            musteri1.Soyadi = "Veli";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Ayşe";
            musteri2.Soyadi = "Korkut";

            //musteriManager nesnesi ile MusteriManager sınıfına erişeceğiz
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.musteriEkle(musteri1);
            musteriManager.musteriEkle(musteri2);
            Console.WriteLine("-------------------");
            musteriManager.musterileriListele();
            musteriManager.musteriSil(musteri2);
            Console.WriteLine("-------------------");
            musteriManager.musterileriListele();
        }
    }
}
