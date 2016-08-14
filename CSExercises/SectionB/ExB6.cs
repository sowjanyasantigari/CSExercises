using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            double X1, Y1, X2, Y2;
            double Distance;

            Console.Write("Enter value for X1 : ");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value for Y1 : ");
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value for X2 : ");
            X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value for Y2 : ");
            Y2 = Convert.ToDouble(Console.ReadLine());

             Distance = CalculateDistance(X1, Y1, X2, Y2);
            Console.WriteLine("The distance between the point1({0},{1}) and point2({2},{3}) is {4}", X1, Y1, X2, Y2, Distance);

        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance;
            distance = Math.Sqrt( (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
    }
} 
