using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovHT2_2
{
    internal class Program
    {
        static string ENTER_THE_COEFFICIENT = "Please, enter the {0} coefficient:";
        static double Round(double a)
        {
            return (Math.Round(a * 100)) / 100;
        }

        static void Error()
        {
            Console.WriteLine("Wrong input. Please, try again:");
        }

        // nonZero - input must not equals zero
        static double ReadDouble(bool nonZero)
        {
            double result = 0;
            bool cond = true;
            while (cond)
            {
                bool convert = double.TryParse(Console.ReadLine().Replace(",", "."), out result);
                bool nonZeroFlag = (nonZero && result != 0) || !nonZero;

                if (nonZeroFlag && convert)
                {
                    cond = false;
                }
                else
                {
                    Error();
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This program solves quadratic equations");
            Console.WriteLine("Please, input parts of quadratic equation a^2 * x + b * x + c = 0");
            Console.WriteLine(ENTER_THE_COEFFICIENT, "a");
            double a = ReadDouble(true);
            Console.WriteLine(ENTER_THE_COEFFICIENT, "b");
            double b = ReadDouble(false);
            Console.WriteLine(ENTER_THE_COEFFICIENT, "c");
            double c = ReadDouble(false);

            double d = Math.Pow(b, 2.0) - 4 * a * c;
            string evaluation = $"{a}^2 * x + {b} * x + {c}";
            if (d > 0)
            {
                double sqrtD = Math.Sqrt(d);
                double x1 = Round((-b - sqrtD) / (2 * a));
                double x2 = Round((-b + sqrtD) / (2 * a));
                Console.WriteLine($"The {evaluation} has two roots:" +
                    $"\nx1 = {x1} \nx2 = {x2}");
            }
            else if (d == 0)
            {
                double x = Round(-b / (2 * a));
                Console.WriteLine($"The root of {evaluation} is:\n{x}");
            }
            else
            {
                Console.WriteLine($"{evaluation} has no any roots");
            }
            Console.WriteLine("Please, press any key to continue");
            Console.ReadKey();
        }
    }
}
