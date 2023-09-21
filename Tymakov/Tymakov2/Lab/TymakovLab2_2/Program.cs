using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovLab2_2
{
    internal class Program
    {
        static void Error()
        {
            Console.WriteLine("Wrong input. Please, try again:");
        }

        // This function try to convert input to int and if this impossible asks to try again
        static int ReadInt()
        {
            int result = 0;
            bool cont = true;
            while (cont)
            {
                bool convert = int.TryParse(Console.ReadLine(), out result);
                if (convert)
                {
                    cont = false;
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
            Console.WriteLine("This app will do a/b. Please, enter the coefficients");
            double Divide()
            {
                Console.WriteLine("Please, write a:");
                int a = ReadInt();
                Console.WriteLine("Please, write b:");
                int b = ReadInt();
                return a / b;
            }

            double result = 0.0;
            bool cond = true;
            while (cond)
            {
                try
                {
                    result = Divide();
                    cond = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an attempt to divide by zero. Please, check your input and try again\n");
                }
            }

            Console.WriteLine(result);
            Console.WriteLine("Please, press any key to continue");
            Console.ReadKey();
        }
    }
}