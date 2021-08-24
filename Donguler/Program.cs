using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //array-Dizi

            string[] kurslar = new string[]
            {
                "Yazılın","Muhaebe","Matematik","Python","C#"
            };
        
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("--------------------------------");

            //Forech dizilere uygulanılır.Dizileri tek tek dolaşır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.ReadLine();
        }
    }
}
