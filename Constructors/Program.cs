using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        //Ödev2
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(2,"ahmet","dogan","adıyaman");
            Customer customer2 = new Customer() { Id=1,FirstName="Selim",LastName="dogan",City="Ankara"};
          
        }
    }

    class Customer
    {
        //Default Customer 
        public Customer(int id)
        {
            Console.WriteLine("Yapıcı lok çalıştı");
            Console.ReadLine();
        }
        public Customer()
        {

        }
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }


}
