using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        // The four basic elements of a counter-controlled repetition are:a controlled variable, initial value of control variable, the increment which control var. is modified through the loop, and the loop-continuation condidtion that determines if loop will continue. 
        // The for statement is used for counter controlled rep, while statement is for sentinel controlled rep.The while statement is used to implement any counter controlled loop; the for repetition statement is used to specify the counter controlled rep in detail within a single line of code.
        // We would use a "use do...while" statement instead when a set of instructions/statements need to be executed at least once. For example if we needed to input a set of int that range 1 through 5 and find the cumulative sum.

        {
            for(int i=1; i<101;i++)
            {
                Console.WriteLine(i);
                {
                    if((i%2)==0)
                    { Console.WriteLine("The number is even"); }
                    else if((i%2)!=0)
                    { Console.WriteLine("The number is odd"); }
                }
            }

            {
                Console.WriteLine("Please enter a temperature: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp >= 90) { Console.WriteLine("Fish"); }
                else if (temp >= 80) { Console.WriteLine("Lion"); }
                else if (temp >= 70) { Console.WriteLine("Turtle"); }
                else if (temp >= 60) { Console.WriteLine("Deer"); }
                else if (temp >= 50) { Console.WriteLine("Reindeer"); }
                else if (temp >= 40) { Console.WriteLine("Moose"); }
                else if (temp >= 20) { Console.WriteLine("Penguin"); }
                else if (temp >= 10) { Console.WriteLine("Polar Bear"); }
                else { Console.WriteLine("Bug"); }

            }
            {// #7
                int i = 9;
                while (i < 20)
                {
                    i++;
                    Console.WriteLine(i);
                }


                // #8
                for (int I = 0; I < 101; I++)
                { Console.WriteLine(I); 
                 Console.WriteLine("********"); }

            }

        }
    }
}
