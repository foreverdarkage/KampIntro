using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "temel kurs";
            string kurs3 = "java kursu";
            string[] kurslar = new string[] { "yazılım geliştirici kampı", "temel kurs", "java kursu" };

            for (int i = 0; i < 1 ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfasonu");
        }
    }
}
