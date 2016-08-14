using System;

namespace CSExercises
{
    public class ExB10
    { 
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            double A, B, C;
            double areaOfTriangle;

            Console.Write("Enter length of side A of triangle :");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter length of side B of triangle :");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter length of side C of triangle :");
            C = Convert.ToDouble(Console.ReadLine());

            areaOfTriangle = CalculateArea(A, B, C);
            Console.WriteLine("The area of given triangle is {0}", areaOfTriangle);

            // If one of the sides of the triangle is greater than or equal to the sum of the other two sides,
            // then the triangle cannot be formed and this program returns NaN value.


        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s;
            double Area;
            s = (a + b + c) / 2;
            Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return Area;
            
            
        }
    }
}