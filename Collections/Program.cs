using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Another", "Human", "Being" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //names = new string[4];
            //names[3] = "foreverdarkage";
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[3]);

            List<string> names2 = new List<string> { "mindy", "the kid" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);            
            names2.Add("mdhkcd");
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[1]);

        }
    }
}
