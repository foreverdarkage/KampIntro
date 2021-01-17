using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Sepete Eklendi: " + product.Name);
        }

        public void Add2(string productname, string explaination, double Prize, int amountleft) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productname);      
        }        
    }
}
