using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.Egitmeni = "dogan";
            kurs1.KursAdi = "C#";
            kurs1.Izlenmeorani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmeni = "Dadadadunasdus";
            kurs2.KursAdi = "asdasdC#";
            kurs2.Izlenmeorani = 40;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmeni = "Doganyunus";
            kurs3.KursAdi = "nnnnnnnnC#";
            kurs3.Izlenmeorani = 80;

            //kursları hepsını bır dızıde tutuyoruz.
            Kurs[] kurslar = new Kurs[] {
            kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : "+kurs.Egitmeni);
            }


            

      

            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmeni);
            Console.ReadLine();

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int Izlenmeorani { get; set; }
        
        

    }




}
