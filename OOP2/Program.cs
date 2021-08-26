using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müşteri

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;            
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Kaya";
            musteri1.TcNo = "4541212";


            //Tüzel Müşteri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45454";
            musteri2.VergiNo = "78945566";
            musteri2.SirketAdi = "DoganHolding";

            //Gerçek müşeti-Tüzel Müşteri
            //SOLID




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



          
            
            Console.ReadLine();


         
        }
    }
}
