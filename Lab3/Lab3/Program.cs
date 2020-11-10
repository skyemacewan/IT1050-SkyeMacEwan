using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        { //Question 3, two int variables
            int SpeedLimit;
            int Speed;

            SpeedLimit = 35;
            Speed = 42;

            if (Speed > SpeedLimit)
                Console.WriteLine("SLOW NOW");


            // Question 4, if-else statement
            int IsTrue = 7;
            if(IsTrue < 9)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False");
            }


            // Question 5, if statement
            Console.WriteLine("Input temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double Celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius is {0}", Celsius);
            Console.ReadLine();

            if (fahrenheit >= 90)
                Console.WriteLine("It is hot");
            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");

            //Question 6, while loop 1-10
            int a = 1;
            while (a<11)
            {
                Console.WriteLine("Value: ");
                Console.WriteLine(a); a++;
            }

            // Question 7, while loop 60-20
            int b = 60;
            while (b>=20)
            {
                Console.WriteLine("Value: ");
                Console.WriteLine(b); b--;
            }

            //Question 8, while loop 10-20

            int c = 10;
            while (c<=20)
            {
                Console.WriteLine("Value: ");
                Console.WriteLine(c); c=c+2;
            }


        }
    }
}


// The repetition statement while is used to execute a series of statement many times depending on the given condition. The conditional statement if single-selection is used to execute a piece of code depending on if a given condition is true or false. 
// These two are similar because they only work if the given condition is true, the syntax and structure of both are almost the same, and in certain conditions they can be used interchangeably. 
// The biggest differences are that If single-selection statements can be guaranteed to run only one time or never, while is a looping statement that can run multiple times. Secondly, the behaviors of single-selection statements can be determined in most cases, while looping cannot be determined until run time. 

