using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectMdhkcd
{
    interface ISaleCampaignService
    {
        void Add(SaleCampaign saleCampaign, Sale sale);
        void Update(SaleCampaign saleCampaign, Sale sale);
        void Delete(SaleCampaign saleCampaign, Sale sale);
    }
}
