using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovHT2_1
{
    internal class Program
    {
        static char IncreaseChar(char first, char last, char current)
        {
            return (char)(((current - first + 1) % (last - first + 1) + first));
        }

        static void Error()
        {
            Console.WriteLine("Wrong input. Please, try again");
        }

        static char ReadChar()
        {
            char result = 'a';
            bool cond = true;
            while (cond)
            {
                string inputString = Console.ReadLine();
                if (inputString.Length == 1)
                {
                    char input = inputString[0];
                    if (input >= 'A' && input <= 'Z')
                    {
                        result = IncreaseChar('A', 'Z', input);
                        cond = false;
                    }
                    else if (input >= 'a' && input <= 'z')
                    {
                        result = IncreaseChar('a', 'z', input);
                        cond = false;
                    }
                    else
                    {
                        Error();
                    }
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
            Console.WriteLine("This program read a letter and then print the next one in the alphabet\n" +
                "Please, enter any character:");
            Console.WriteLine(ReadChar());
            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}