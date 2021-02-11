using GameProject.Nesneler;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class OyunManager : IOyuncuVeOyun
    {
        public void Ekle()
        {
            Console.WriteLine("Oyun Eklendi");
        }
        public void Güncelle()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void OyunSat(Oyuncu oyuncu, Oyun oyun)
        {
            Console.WriteLine(oyuncu.Adi + " oyuncusuna " + oyun.OyunAdi +" satılmıştır.");
            oyun.OyunAdet--; //oyun satıldıktan sonra stoktan 1 tane eksildi. 
            //burada kasanın parası da arttırılabilir.
        }

        public void OyunSat(Oyuncu oyuncu, Oyun oyun, Kampanya kampanya)
        {
            //overloading yaptım ki kampanyalı şekilde de satabileyim
            Console.WriteLine(oyuncu.Adi + " oyuncusuna " + oyun.OyunAdi + " " + kampanya.KampanyaAdi +"kampanyası ile satılmıştır.");
        }

       
    }
}
