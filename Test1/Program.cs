using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main (string[] args)
        {
            int num, num_1;
            
            Console.WriteLine("Enter first number: ");
            num = Convert.ToInt32() (Console.ReadLine());  //Конвертация в число
            Console.WriteLine("\nEnter second number: ");
            num_1 = Convert.ToInt32() (Console.ReadLine());
            Console.WriteLine("The result is: " + (num + num_1));
        }
    }
}
