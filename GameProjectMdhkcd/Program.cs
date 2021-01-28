using System;

namespace GameProjectMdhkcd
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerValidManager());
            SaleManager saleManager = new SaleManager();
            SaleCampaignManager saleCampaignManager = new SaleCampaignManager();
            Console.WriteLine("Player stuffs");
            playerManager.Add(new Player { BirthYear = 1988, Name = "Memduh", Surname = "Kocadağ", PlayerId = 1, Username = "mindy" });
            Player player2 = new Player();
            player2.BirthYear = 1989;
            player2.Name = "Danil";
            player2.Surname = "Ishutin";
            player2.PlayerId = 2;
            player2.Username = "Dendi";
            Sale sale1 = new Sale();
            sale1.SaleId = 1;
            sale1.GameName = "Mordhau";
            sale1.Price = 50;
            Sale sale2 = new Sale();
            sale2.SaleId = 2;
            sale2.GameName = "AoE2:DE";
            sale2.Price = 45;
            SaleCampaign saleCampaign1 = new SaleCampaign();
            saleCampaign1.SaleCampaignId = 1;
            saleCampaign1.SaleCampaignName = "Casual";
            saleCampaign1.SaleCampaignPercent = 30;
            playerManager.Delete(player2);
            playerManager.Update(player2);
            Console.WriteLine("Selling process");
            saleManager.MakeSale(sale2, player2);
            Console.WriteLine("Sale process");
            saleCampaignManager.Add(saleCampaign1, sale1);
            saleCampaignManager.Add(saleCampaign1, sale2);
            Console.WriteLine("The process has been accomplished successfully");
            saleCampaignManager.Delete(saleCampaign1, sale1);
            Console.WriteLine("The sale has been removed successfully");
            saleCampaignManager.Update(saleCampaign1, sale2);

        }
    }
}
