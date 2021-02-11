using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class OyuncuManager:IOyuncuVeOyun
    {
        public void Ekle()
        {
            //Kontrol yapılacakdoğruysa
            Console.WriteLine("Oyuncu Sisteme Eklendi");
        }

        public void Güncelle()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            Console.WriteLine("Oyuncu Sistemden Silindi");
        } 
    }
}
