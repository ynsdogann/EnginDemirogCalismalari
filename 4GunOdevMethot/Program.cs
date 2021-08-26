using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GunOdevMethot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result=Add2(6, 9);

            //Console.WriteLine(result);
            //var result = carpma(6, 8);
            //Console.WriteLine(result);
            //var result = carpma1(2,4,3);
            //Console.WriteLine(result);
           
            Console.WriteLine(add4(2,3,5,7));//params kullanımı
            Console.ReadLine();
            
         
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1,int number2)// void git bir yere git işlem yap demek 
        {

            var result = number1 + number2;
            return result;
        }
         static int carpma (int sayi1, int sayi2)
        {
            var result = sayi1 * sayi2;
            return result;
        }
        //Methot Overloading
        static int carpma1(int sayi1, int sayi2,int sayi3)
        {
            var result = sayi1 * sayi2*sayi3;
            return result;
        }
        //Params Kullanımı
        static int add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
