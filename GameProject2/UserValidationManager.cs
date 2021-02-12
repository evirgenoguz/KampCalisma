using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1998 && gamer.FirstName == "Oguz" && gamer.LastName == "Evirgen")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
