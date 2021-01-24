using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Another");
            myDictionary.Add(2, "Human Being");

            Console.WriteLine(myDictionary.Counter-1);
            myDictionary.Iterate();
        }
    }
}
