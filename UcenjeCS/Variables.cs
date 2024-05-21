using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Variables
    {
        public static void Izvedi()
        {
            int truth = 42;
            
            double pie = 3.141592653;

            bool valid = true;

            string magic = "The magic number: ";

            Console.WriteLine(magic + truth);
            Console.WriteLine("Life of " + pie);
            Console.WriteLine("This is awesome: " + valid);

            Console.WriteLine("-------------------------------");

            int number = 42;

            Console.WriteLine(number);

            number = 21;

            Console.WriteLine(number);

            Console.WriteLine("--------------------------------");

            double a = 3.14;
            double b = 22.0;
            double c = a * b * b;

            Console.WriteLine(c);

            double pi = 3.14;
            double radius = 22.0;
            double area = a * b * b;

            Console.WriteLine(area);

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Give a message: ");

            string message = Console.ReadLine();
            
            Console.WriteLine(message);

            Console.WriteLine("----------------------------------");

            Console.Write("Give integer value: ");
            
            string userInput = Console.ReadLine();
            
            int intValue = Convert.ToInt32(userInput);
            
            Console.WriteLine("You gave " + intValue);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Give double value: ");

            userInput = Console.ReadLine();

            double doubleValue = Convert.ToDouble(userInput);

            Console.WriteLine("You gave " + doubleValue);

            Console.WriteLine("------------------------------------");

            string truth2 = "True";

            bool booleanValue = System.Convert.ToBoolean(truth2);
           
            Console.WriteLine(booleanValue);

            truth2 = "False";

            booleanValue = System.Convert.ToBoolean(truth2);
            
            Console.WriteLine(booleanValue);





        }
    }
}
