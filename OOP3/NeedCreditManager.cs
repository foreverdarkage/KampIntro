using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            throw new NotImplementedException();
        }

        public void Evaluate()
        {
            Console.WriteLine("Needing credits payment plan is evaluated");
        }
    }
}
