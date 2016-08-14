using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes a double precision number as input 
    //and prints the square of that number
    //For this exercise, you need to implement the square function
    //and handle the input and output in the Main method (use Exercise 2 as an example)

    public class ExA4
    {
        public static void Main(string[] args)
        {
            double d;
            double result;
            Console.WriteLine("Enter a precision number to find square of the number");
            d = Convert.ToDouble(Console.ReadLine());

            result = square(d);
            Console.WriteLine("Square of the input number is {0} ", result);
        }

        public static double square(double x)
        {
            double result;
            result = x * x;

            return result;

        }
    }
}
