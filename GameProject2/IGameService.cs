using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    interface IGameService
    {
        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);
    }
}
