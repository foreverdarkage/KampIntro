using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualClient client1 = new IndividualClient();
            client1.Id = 1;
            client1.ClientId = "11111";
            client1.Name = "Memduh";
            client1.Surname = "Kocadağ";
            client1.NationalId = "11111111";

            CorporateClient client2 = new CorporateClient();
            client2.Id = 2;
            client2.ClientId = "212121";
            client2.CompanyName = "consicous";
            client2.TaxId = "12121212";

            Client client3 = new IndividualClient();
            Client client4 = new CorporateClient();

            ClientManager clientManager = new ClientManager();
            clientManager.Add(client1);
            clientManager.Add(client2);


        }
    }
}
