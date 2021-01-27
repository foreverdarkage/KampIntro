using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();           
            ICreditManager vehicleCreditManager = new VehicleCreditManager();            
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(new SellerCreditManager(), new SMSLoggerService());
            

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, housingCreditManager};
            //applyManager.CreditEarlyBriefing(credits);
            
        }
    }
}
