using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemegirisYapmismi = false;
            double dolardun = 7.35;
            double dolarbugün = 7.45;

            if (dolardun>dolarbugün)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolardun < dolarbugün)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemegirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
