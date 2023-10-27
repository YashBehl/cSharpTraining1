using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Principal Amount: ");
            var principal = Console.ReadLine();
            double p;
            if(!Double.TryParse(principal, out p))
            {
                Console.Write("Enter Principal Amount (in numbers only): ");
                principal = Console.ReadLine();
            }

            Console.Write("Enter Rate: ");
            var rate = Console.ReadLine();
            double r;
            if (!Double.TryParse(rate, out r))
            {
                Console.Write("Enter Rate (in numbers only): ");
                rate = Console.ReadLine();
            }
            

            Console.Write("Enter Time: ");
            var time = Console.ReadLine();
            double t;
            if (!Double.TryParse(time, out t))
            {
                Console.Write("Enter time (in numbers only): ");
                time = Console.ReadLine();
            }

            p = Convert.ToDouble(principal);
            r = Convert.ToDouble(rate);
            t = Convert.ToDouble(time);

            double simpleInterest = Convert.ToDouble(p * r * t / 100);

            Console.WriteLine("Simple Interest = " + simpleInterest);



            int integerVariable = 500;
            double doubleVariable = 41.56;
            bool booleanVariable = false;
            Console.Write("Enter a string: ");

            string stringVariable = Console.ReadLine();


            Console.WriteLine(Convert.ToDouble(integerVariable));
            Console.WriteLine(Convert.ToBoolean(integerVariable));
            Console.WriteLine(Convert.ToString(integerVariable));
            Console.WriteLine(Convert.ToInt32(doubleVariable));
            Console.WriteLine(Convert.ToBoolean(doubleVariable));
            Console.WriteLine(Convert.ToString(doubleVariable));
            Console.WriteLine(Convert.ToInt32(booleanVariable));
            Console.WriteLine(Convert.ToDouble(booleanVariable));
            Console.WriteLine(Convert.ToString(booleanVariable));
            int convertedVariable;
            double convertedVariable2;
            if (int.TryParse(stringVariable, out convertedVariable))
            {
                Console.WriteLine(Convert.ToInt32(stringVariable));
            }
            else if (Double.TryParse(stringVariable, out convertedVariable2))
            {
                Console.WriteLine(Convert.ToDouble(stringVariable));
            }
            Console.ReadKey();
        }
    }
}
