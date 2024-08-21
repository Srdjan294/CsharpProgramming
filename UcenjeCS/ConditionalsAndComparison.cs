using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ConditionalsAndComparison
    {
        public static void Izvedi()
        {
            Console.WriteLine("Hello World!");

            if (true)
            {
                Console.WriteLine("This is always printed!");
            }

            int number = 11;

            if(number > 10)
            {
                Console.WriteLine("The number was larger than 10");
            }



            int number2 = 55;

            if(number2 != 0)
            {
                Console.WriteLine("The number was not equal to zero");
            }

            if(number2 >= 1000)
            {
                Console.WriteLine("The number was at least 1000");
            }


            Console.WriteLine("**************************");
            Console.WriteLine("Else option");

            int number3 = 4;

            if (number3 > 5)
            {
                Console.WriteLine("Your number is greater than five!");
            }
            else
            {
                Console.WriteLine("Your number is 5 or less!");
            }

            Console.WriteLine("***************************");
            Console.WriteLine("Else if");

            int number4 = 3;

            if (number4 == 1)
            {
                Console.WriteLine("Number is one!");
            }
            else if(number4 == 2)
            {
                Console.WriteLine("Number is two!");
            }
            else if(number4 == 3)
            {
                Console.WriteLine("Number is three!");
            }
            else
            {
                Console.WriteLine("Number is something else");
            }


            Console.WriteLine("******************************");
            Console.WriteLine("Order of Comparison");

            int number5 = 42;

            if (number5 == 0)
            {
                Console.WriteLine("The number is greater than 0.");
            }
            else if(number5 > 0)
            {
                Console.WriteLine("The number is greater than 0.");
            } 
            else if(number5 > 2) 
            {
                Console.WriteLine("The number is greater than 2.");
            }
            else
            {
                Console.WriteLine("The number is smaller than 0.");
            }

            Console.WriteLine("******************************");
            Console.WriteLine("Conditional Statement and Boolean Variable");

            bool truthValue = true;
            Console.WriteLine("The value of truthValue is " + truthValue);

            if(truthValue)
            {
                Console.WriteLine("This is awesome!");
            }

            int first = 1;

            int second = 3;

            bool isFirstLargerThanSecond = first < second;

            if(isFirstLargerThanSecond)
            {
                Console.WriteLine(first + " is less than " + second + "!");
            }


            Console.WriteLine("************************************");
            Console.WriteLine("Remainder");

            int remainder = 7 % 2;
            Console.WriteLine(remainder);   // 1
            Console.WriteLine(5 % 3);       // 2
            Console.WriteLine(7 % 4);       // 3
            Console.WriteLine(8 % 4);       // 0
            Console.WriteLine(1 % 2);       // 1


            Console.WriteLine("Input number");

            string userInput = Console.ReadLine();
            
            int number6 = Convert.ToInt32(userInput);

            if((number6 % 400) == 0)
            {
                Console.WriteLine("The number " + number6 + " is divisible by four hundred");
            }
            else
            {
                Console.WriteLine("The number " + number6 + " is not divisible by four hundred");
            }


            Console.WriteLine("**********************************");
            Console.WriteLine("Conditionals an Equality of Variables");

            string a = "word";
            string b = "word";
            
            Console.WriteLine(a == b);

            Console.WriteLine(a.Equals(b));

        }
    }
}
