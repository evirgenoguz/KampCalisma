using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class OrderManager : IOrderService
    {  
        public void Order(Game game, Campaign campaign)
        {
            

            double newPrice = game.GamePrice - ((game.GamePrice * campaign.Discount) / 100);

            Console.WriteLine("Sipariş Edilen oyunun kampanyalı fiyatı : " + newPrice);
        }
    }
}
