using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService) 
        {
            creditManager.Evaluate();
            loggerService.Log();
        }

        public void CreditEarlyBriefing(List<ICreditManager>credits) 
        {
            foreach(var credit in credits) 
            {
                credit.Evaluate();
            }
        }
    }
}
