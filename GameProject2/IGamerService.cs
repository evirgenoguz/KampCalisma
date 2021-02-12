using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);
    }
}
