using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectMdhkcd
{
    class SaleManager:ISaleService
    {
        public void MakeSale(Sale sale, Player player) 
        {
            Console.WriteLine(sale.GameName+ " is added to library.");
        }
    }
}
