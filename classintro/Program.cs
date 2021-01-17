using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product
            {
                marka = "asus",
                model = "zenfone3",
                Fiyat = 1500
            };

            product product2 = new product
            {
                marka = "sony",
                model = "vaio2",
                Fiyat = 3000
            };

            product product3 = new product
            {
                marka = "xiomi",
                model = "xyz",
                Fiyat = 4500
            };

            product[] products = new product[] {product1, product2, product3};

            foreach (var product in products)
            {
                Console.WriteLine(product.marka + " " + product.model + " " + product.Fiyat);
            }

            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine(products[i].marka + " " + products[i].model + " " + products[i].Fiyat);
            }

            int x = 2;
            while (x<products.Length)
            {
                Console.WriteLine(products[x].marka + " " + products[x].model + " " + products[x].Fiyat);
                x++;
            }
                    
            
        }
               

       
        }
    }

class product
{
    public string marka { get; set; }
    public string model { get; set; }
    public int Fiyat { get; set; }
}
