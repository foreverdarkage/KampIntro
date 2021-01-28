using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectMdhkcd
{
    interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
