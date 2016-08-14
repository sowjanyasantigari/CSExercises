using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            double d;
            double result;
            Console.WriteLine("Enter double precision number to find squareroot");
            d = Convert.ToDouble(Console.ReadLine());

            result = SQRT(d);
            Console.WriteLine("Square root of the {1} is {0}", result, d);
        }

        public static double SQRT(double x)
        {
            double result;
            result = Math.Sqrt(x);
            return result;

        }
    }
}
