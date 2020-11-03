using System;

namespace Lab2
{
    public class Multiplication
    {
        // main method begins execution of C# application
       public static void Main(string[] args)
        {
            Console.WriteLine("{0}\n{1}", "Hello World!", "From Skye MacEwan");
            Console.WriteLine("{0}\t{1}", "Hello World!", "From Skye MacEwan");

            int number1; //input number 1
            int number2; // input number 2
            int sum; // sum of number1 and number2

            Console.WriteLine("Enter first number:"); // prompt input
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:"); // prompt input
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 * number2; //multiply  numbers

            Console.WriteLine("Sum is {0}", sum); //display sum

        }
    }
} // A. The main method is where the execution of the application is.
// B. Integer data allows variable to store numeric values in a whole number form, while double/float will store an approximation of real numbers including decimal points.
// C. We can create a instance variable which you can use to call upon, in ch 4 they used the example of  Course.name to call upon multiple times within figure 4.8. For example Console.WriteLine("Welcome to the grade book for\n(0)!", CourseName);
// D. get, set
// E. A class is used to house a method, while objects is an instance of the class. You can create as many classes as you need as long as each on is different. For example we could make the class "Cat": Cat cat1=new Cat(); Cat cat2=new Cat();... and so on. Now cat1 and cat2 are multiple instances of the class "Cat". 
