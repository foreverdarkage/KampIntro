using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectMdhkcd
{
    class SaleCampaignManager:ISaleCampaignService
    {
        public void Add(SaleCampaign saleCampaign, Sale sale)
        {
            Console.WriteLine(sale.GameName+ " has %" +saleCampaign.SaleCampaignPercent+ " sales in this week.");        
        }
        public void Delete(SaleCampaign saleCampaign, Sale sale) 
        {
            Console.WriteLine("the sale for "+sale.GameName+ " has just ended");
        }
        public void Update(SaleCampaign saleCampaign, Sale sale) 
        {
            Console.WriteLine(sale.GameName + " has new sale on the stores for a limited time.");
        }
    }
}
