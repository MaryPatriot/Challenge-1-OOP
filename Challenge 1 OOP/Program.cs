using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Bankac Customer1 = new Bankac("123456", 1500, "John Robert", "John@gmail.com", 432542) ;

            Console.WriteLine(Customer1.CustomerName);
            Console.WriteLine(Customer1.Balance);
            Console.WriteLine(Customer1.Email);
            Console.WriteLine(Customer1.AcNumber);
            Console.WriteLine(Customer1.PhoneNumber);
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine(Customer1.AddMoney(150));
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine(Customer1.DeductMoney(1651));
           
           
         
        }
    }
}
