using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void musteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Isim + " Müşteri Olarak Eklendi");

        }
        public void musterileriListele()
        {
            Console.WriteLine("Müşterilerimiz");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Isim + " " + musteri.Soyadi);
            }
        }
        public void musteriSil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri Silindi");
        }
    }
}
