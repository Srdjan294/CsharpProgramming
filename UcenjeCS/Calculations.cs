using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Calculations
    {
        public static void Izvedi()
        {
            int first = 2;
            Console.WriteLine(first);

            int second = 4;
            Console.WriteLine(second);

            int sum = first + second;
            Console.WriteLine(sum);

            Console.WriteLine("******************************");

            int calcWithBrackets = (1 + 1) + 3 * (2 + 5);
            Console.WriteLine(calcWithBrackets);

            int calcWithoutBrackets = 1 + 1 + 3 * 2 + 5;
            Console.WriteLine(calcWithoutBrackets);


            Console.WriteLine("*********************************");

            int first2 = 42;
            int second2 = 2;

            Console.WriteLine(first2 + second2);

            Console.WriteLine("**********************************");

            int truth = 42;
            Console.WriteLine("The magic number is " + truth + ".");

            Console.WriteLine("**************************************");

            Console.WriteLine("The magic number is " + 42 + ".");
            Console.WriteLine( 42 + " is the magic number.");

            Console.WriteLine("*************************************");


            Console.WriteLine("Four: " +  (2 + 2));
            Console.WriteLine("But! Twenty-two: " + 2 + 2);


            Console.WriteLine("*************************************");

            int x = 10; ;

            Console.WriteLine("value of x is: " + x);

            int y = 5;
            int z = 6;

            Console.WriteLine("y is: " + y + " and z is " + z);

            Console.WriteLine("******************************************");

            Console.WriteLine(3 * 2);
            Console.WriteLine(2+2+2);

            Console.WriteLine("********************************************");

            Console.WriteLine(13 / 5);
            Console.WriteLine(-13 / 5);
            Console.WriteLine(13 / -5);
            Console.WriteLine(-13 / -5);

            Console.WriteLine("**********************************************");

            Console.WriteLine(13 / 5.0);

            int w = 13;
            int u = 5;

            Console.WriteLine((double)w / u);

            Console.WriteLine("*********************************************");

            int first3 = 13;
            int second3 = 6;
            int third3 = 42;

            double average = (first3 + second3 + third3) / 3.0;
            Console.WriteLine(average);

            Console.WriteLine("*******************************************");

            int first4 = (1 + 1);
            int second4 = first4 + 3 * (2 + 5);

            first4 = 5;

            int third4 = first4 + second4;
            Console.WriteLine(first4);
            Console.WriteLine(second4);
            Console.WriteLine(third4);








        }
    }
}
