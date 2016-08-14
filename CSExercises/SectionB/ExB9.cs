using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            double mtotalfare;
            double distanceTravelled;
            Console.WriteLine("Enter the distance travelled in kilometers");
            distanceTravelled = Convert.ToDouble(Console.ReadLine());
            mtotalfare = CalculateFare(distanceTravelled);
            Console.WriteLine(" The total fare for the distance travelled is ${0:0.0}", mtotalfare);

        }

        public static double CalculateFare(double distance)
        {
            double ftotalfare;
            double roundvalue = 10 ;
             const double fixedcharge = 2.40;
             const double additionalfare = 0.4;
            ftotalfare = fixedcharge + distance * additionalfare;
            ftotalfare = Math.Ceiling(ftotalfare * roundvalue )/roundvalue;

            return ftotalfare;

        }
    }
}
