using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        
        public static void Main(string[] args)
        {

            string salaryStr;

            Console.WriteLine("Enter salary");
            salaryStr = Console.ReadLine();

            CalculateIncome( salaryStr);


            
            

        }

        public static string CalculateIncome(string salaryStr)
        {
            double totalsalary;
            double salary;
            double housingallowance;
            double  transport;
            
            salary = Convert.ToDouble(salaryStr);

            housingallowance = (salary / 100) * 10;
                transport = (salary / 100) * 3;
            
            totalsalary = salary + housingallowance + transport;

            Console.WriteLine("The housing allowance is {0}", housingallowance);
            Console.WriteLine("The transport allowance is {0}", transport);
            Console.WriteLine("The total salary is {0:$#,##0.00}", totalsalary);
            return null;
        }
    }
}
