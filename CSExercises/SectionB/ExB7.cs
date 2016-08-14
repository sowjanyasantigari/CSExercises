using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            double mtotalfare;
            double distanceTravelled;
            Console.WriteLine("Enter the distance travelled in kilometers");
            distanceTravelled = Convert.ToDouble(Console.ReadLine());
            mtotalfare = CalculateFare(distanceTravelled);
            Console.WriteLine(" The total fare for the distance travelled is ${0}",mtotalfare);

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
