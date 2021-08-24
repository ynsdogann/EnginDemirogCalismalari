using System;

namespace EnginDemirogCalismalari
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety= Tip güvenliği demek
            // Do not repat yourself =kendını tekrarlama

            string kategoriEtiketi = "Kategori";
            int maas = 3200;
            double faiz = 1.45;
            bool girisyaptimi = true;
            double dolardun = 7.55;
            double dolarbugun = 7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolardun<dolarbugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
                      
            if (girisyaptimi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);     
                       
            Console.ReadLine();
        }
    }
}
