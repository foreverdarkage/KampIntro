using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectMdhkcd
{
    class PlayerManager:IPlayerService
    {
        IPlayerValidService _playerValidService;
        public PlayerManager(IPlayerValidService playerValidService) 
        {
            _playerValidService = playerValidService;
        }
        public void Add(Player player) 
        {
            if (_playerValidService.Valid(player) == true) 
            {
                Console.WriteLine(player.Username+" has been added.");
            }
            else 
            {
                Console.WriteLine("User "+player.Username+ " couldn't have been created");
            }
        }
        public void Delete(Player player) 
        {
            Console.WriteLine("User " +player.Username+ " has been deleted from our databese.");
        }
        public void Update(Player player) 
        {
            Console.WriteLine("The information for "+ player.Username+" has been updated.");
        }
    }
}
