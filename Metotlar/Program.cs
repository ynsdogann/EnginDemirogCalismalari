using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();// Class ornegı olusturduktan sonra urun clasına ulasabiliriz.
            urun1.Adi = "Elma";
            urun1.Fiyati=15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adıyaman Karpuzu";

            Urun[] urunler = new Urun[] // Arary yanı dızın olusturuyoruz
            {
                urun1,urun2
            };
            //type-safe-- tip güvenliği
            foreach (var urun in urunler)
            {

                Console.WriteLine("Ürün Adı:"+urun.Adi);
                Console.WriteLine("Ürün Fiyatı:"+urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması:"+urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-----------------Metotlar---------");

            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);
            sepetManager.Ekle2("Armut","yeşil",12,15);
            sepetManager.Ekle2("Elma", "Mavi", 12, 13);
            sepetManager.Ekle2("Karpuz", "kırmızı", 12, 10);

















            Console.ReadLine();




        }
    }//Dont repat yourself -DRY-clean Code
}
