using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Enter x value ");
            x = Convert.ToDouble(Console.ReadLine());
            y = CalculateY(x);
            Console.WriteLine("The value of y is {0}", y);
        }

        public static double CalculateY(double x)
        {
            double Y;
            Y = 5 * x * x - 4 * x + 3;
            return Y;
        }
    }
}
