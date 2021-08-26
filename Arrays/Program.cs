using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {      

            //Array Tanımlamaları 

            string[] sutudent = new string[3];
            sutudent[0] = "Yunus";
            sutudent[1] = "Miray";
            sutudent[2] = "Tuba";
            //Array Tanımlamaları:Değişken tipi ne ise onla çalışmalıyız.
            string[] student2 = new[] { "ben", "Sen", "onlar" };
            foreach (var student in student2)
            {
               
                Console.WriteLine(student);
            }

            //Çok Boyutlu Diziler

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit "," Balıkkesir" },
                {" Ankara","Konya "," Çankırı" },
                {"Antalya ","Mersin  ","Adana"},
                {"Rize ","Trabzon ","Giresun " },
                {"İzmir ","Muğla ","Aydın " },             

            };
            for (int i = 0; i < regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j < regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
          
            }




            Console.ReadKey();


        }
    }
}
