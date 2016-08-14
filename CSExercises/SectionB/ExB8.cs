using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
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
            const double fixedcharge = 2.40;
            const double additionalfare = 0.4;
            ftotalfare = fixedcharge + distance * additionalfare;

            return ftotalfare;

        }
    }
}
