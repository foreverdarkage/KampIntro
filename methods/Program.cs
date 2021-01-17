using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Prize = 15;
            product1.Explaination = "Amasya Apple";
            product1.Amountleft = 9;

            Product product2 = new Product();
            product2.Name = "Orange";
            product2.Prize = 12;
            product2.Explaination = "Washington Orange";
            product2.Amountleft = 6;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Prize + " " + "TL");
                Console.WriteLine(product.Explaination);
                Console.WriteLine(product.Amountleft + " " + "kaldı");
            }

            Console.WriteLine("-----------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Add(product2);

            sepetmanager.Add2("Banana", "Yellow", 25, 10);
        }
    }
}
