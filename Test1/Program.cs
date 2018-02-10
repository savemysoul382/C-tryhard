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
            const float p = 3.14f;  // trying const
            double num;

            Console.WriteLine("How old are you?");
            num = Convert.ToDouble(Console.ReadLine());  // trying double

            if (num > 18.23d)
            {
                Console.WriteLine("You are older than 18.23");
            }

            Console.ReadKey();

            //Calculator practice
//            int num, num_1;
//            
//            Console.WriteLine("Enter first number: ");
//            num = Convert.ToInt32 (Console.ReadLine());  //Конвертация в число.
//            Console.WriteLine("\nEnter second number: ");
//            num_1 = Convert.ToInt32 (Console.ReadLine());  //Конвертация в число.
//            Console.WriteLine("The result is: " + (num + num_1).ToString());
//            Console.ReadKey();
        }
    }
}
