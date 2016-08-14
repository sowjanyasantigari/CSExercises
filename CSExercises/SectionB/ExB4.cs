using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            double centigrade;
            double fahrenheit;
            Console.WriteLine("Enter temparature in centigrade to convert to fahrenheit");
            centigrade = Convert.ToDouble(Console.ReadLine());
            fahrenheit = ConvertToFahrenheit(centigrade);
            Console.WriteLine("{0}centigrade to fahrenheit is {1}", centigrade, fahrenheit);



        }

        public static double ConvertToFahrenheit(double c)
        {
            double F;
            F = 1.8 * c + 32;

            
            return F ;

        }
    }
}
