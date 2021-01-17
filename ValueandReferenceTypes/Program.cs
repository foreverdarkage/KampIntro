using System;

namespace ValueandReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            
        
            Console.WriteLine(number1);

            int[] numbers1 = new int[] { 1, 2, 3, };
            int[] numbers2 = new int[] { 10, 20, 30 };
            numbers1 = numbers2;
            numbers2[0] = 55;
            Console.WriteLine(numbers1[0]);
        }
    }
}
