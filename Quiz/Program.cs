using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
      
                Console.WriteLine("{0}.Sayıyı Giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi > 0) && (sayi % 2 == 1))
                {
                    Console.WriteLine("sayınız tektir");
                }
                Console.WriteLine();
   

            //Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);
            Console.ReadKey();
        }
    }
}
