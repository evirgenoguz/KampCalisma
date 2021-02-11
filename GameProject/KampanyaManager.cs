using GameProject.Nesneler;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class KampanyaManager : IKampanyaService
    {
        public void YeniFiyat(Oyun oyun, Kampanya kampanya)
        {
            double yeniFiyat = oyun.OyunFiyati - ((oyun.OyunFiyati * kampanya.indirimOrani) / 100);
        }
    }
}
