using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Adlı Oyuncu Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız , Kayıt Olunamadı");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı Oyuncu Güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı Oyuncu Silindi");
        }
    }
}
