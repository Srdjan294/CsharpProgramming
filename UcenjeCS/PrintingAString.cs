using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class PrintingAString
    {
        public static void Izvedi()
        {
            string message = "Print me";
            Console.WriteLine(message);

            Console.WriteLine("message");

            Console.WriteLine("----------------");

            string name = "Doctor Octopus";

            Console.WriteLine("We meet again, " + name);

            string greeting = "We meet again, ";
            
            Console.WriteLine(greeting + name + "!");

            Console.WriteLine("------------------");

            string counting = "One" + "\n" + "Two" + "\n" + "Three";
            
            Console.WriteLine(counting);

            Console.WriteLine("---------------------");

            Console.Write("Give a message: ");

            string message2 = Console.ReadLine();

            Console.WriteLine(message2);

            Console.WriteLine("------------------------");

            Console.Write("Give a message: ");

            string message3 = Console.ReadLine();

            Console.WriteLine("Your message was: " + message3);
        }
    }
}
