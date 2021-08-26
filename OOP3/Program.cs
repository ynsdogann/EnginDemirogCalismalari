using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            IKrediManager esnafkredisi = new EsnafKredisi();
            //esnafkredisi.Hesapla();

            ILogerServices databaseLoggerServices = new DataBaseLogServices();
            ILogerServices filelogservices = new FileLoggerServis();
            ILogerServices smslogServices = new SmsLogServices();

            List<ILogerServices> loggers=new List<ILogerServices> { new SmsLogServices(),new DataBaseLogServices(),new FileLoggerServis()};


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisi(),loggers);

            List<IKrediManager> kredis = new List<IKrediManager>() {tasitKrediManager,ihtiyacKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(kredis);


            Console.ReadLine();
        }
    }
}
