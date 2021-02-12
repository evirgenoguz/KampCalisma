using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Oguz", LastName = "Evirgen", BirthYear = 1998, IdentityNumber = 11111111111 });


            Game game1 = new Game();
            game1.GamePrice = 100; //işlem için sadece bu gerekli

            Campaign campaign1 = new Campaign();
            campaign1.Discount = 15; //işlem için sadece bu gerekli

            OrderManager orderManager = new OrderManager();
             
            orderManager.Order(game1, campaign1); //game1 nesnesinden campaign1 kampanyası ile şipariş oluşturduk.

        }
    }
}
