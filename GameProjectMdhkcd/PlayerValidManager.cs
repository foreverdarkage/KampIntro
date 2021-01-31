using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectMdhkcd
{
    class PlayerValidManager:IPlayerValidService
    {
        public bool Validate(Player player) 
        {
            if(player.BirthYear==1988 && player.Name=="Memduh" && player.Surname=="Kocadağ" && player.Username=="mindy")
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
