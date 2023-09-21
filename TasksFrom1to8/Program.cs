using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFrom1to8
{
    internal class Program
    {
        static int number = 1;

        static void Message(string message)
        {
            Console.WriteLine("\nLet's check problem #{0}\nThis program {1}\nPress any to continue...", number++, message);
            Console.ReadKey();
        }

        static double Round(double a)
        {
            return (Math.Round(a * 100)) / 100;
        }

        static void Error()
        {
            Console.WriteLine("Wrong input. Please, try again:");
        }

        /**
        * Function read the input double and offers to user to try again if he was wrong
        * nonZero - input != 0; only positive - input must be >= 0
        */
        static double ReadDouble(bool onlyPositive, bool nonZero)
        {
            double result = 0;
            bool cond = true;
            while (cond)
            {
                bool convert = double.TryParse(Console.ReadLine().Replace(",", "."), out result);
                bool onlyPositiveFlag = (onlyPositive && result >= 0) || !onlyPositive;
                bool nonZeroFlag = (nonZero && result != 0) || !nonZero;
                
                if (onlyPositiveFlag && nonZeroFlag && convert)
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

        // Function read the input int and offers to user to try again if he was wrong
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
        // Read string which must not equals 0
        static string ReadString()
        {
            string input = "";
            bool cont = true;
            while (cont)
            {
                input = Console.ReadLine();
                if (!input.Equals(""))
                {
                    cont = false;
                }
                else
                {
                    Error();
                }
            }
            return input;
        }
        struct User
        {
            public string name;
            public int age;
            public int pin;
            public string city;
            public void ToString()
            {
                Console.WriteLine($"User's info:\n\tname: {name}\n\tage: {age}\n\tPINT: {pin}\n\tcity: {city}");
            }
        }

        // Solutions run
        static void Main(string[] args)
        {
            void FirstProblem()
            {
                Message("prints min and max value of each C# data type");
                string MASK = "+================================================================================+\n" +
                    "|{0}| --> | {1} <-> {2} |";
                Console.WriteLine(MASK, "bool", bool.FalseString, bool.TrueString);
                Console.WriteLine(MASK, "byte", byte.MinValue, byte.MaxValue);
                Console.WriteLine(MASK, "sbyte", sbyte.MinValue, sbyte.MaxValue);
                Console.WriteLine(MASK, "short", short.MinValue, short.MaxValue);
                Console.WriteLine(MASK, "ushort", ushort.MinValue, ushort.MaxValue);
                Console.WriteLine(MASK, "int", int.MinValue, int.MaxValue);
                Console.WriteLine(MASK, "uint", uint.MinValue, uint.MaxValue);
                Console.WriteLine(MASK, "long", long.MinValue, long.MaxValue);
                Console.WriteLine(MASK, "ulong", ulong.MinValue, ulong.MaxValue);
                Console.WriteLine(MASK, "float", float.MinValue, float.MaxValue);
                Console.WriteLine(MASK, "double", double.MinValue, double.MaxValue);
                Console.WriteLine(MASK, "decimal", decimal.MinValue, decimal.MaxValue);
                Console.WriteLine(MASK, "char", char.MinValue, char.MaxValue);
                Console.WriteLine("+================================================================================+");
            }

            void SecondProblem()
            {
                Message("asks you to fill user's profile and then print it");
                User user = new User();
                Console.WriteLine("Please, enter the user's name:");
                user.name = Console.ReadLine();
                Console.WriteLine("Please, enter the user's age:");
                user.age = ReadInt();
                Console.WriteLine("Please, enter the user's city:");
                user.city = Console.ReadLine();
                Console.WriteLine("Please, enter the user's PIN:");
                user.pin = ReadInt();
                user.ToString();
            }

            void ThirdProblem()
            {
                Message("replaces each uppercase word in input string to lowercase one and vise versa");
                int stepEng = 'a' - 'A'; // English letters
                int stepRus = 'а' - 'А'; // Russian letters
                Console.WriteLine("NOTE: program supports English and Russian alphabets only!\nPlease, enter the string:");
                string input = Console.ReadLine();
                string result = "";

                foreach (char ch in input)
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        result += (char)(ch + stepEng);
                    }
                    else if (ch >= 'a' && ch <= 'z')
                    {
                        result += (char)(ch - stepEng);
                    }
                    else if (ch >= 'А' && ch <= 'Я')
                    {
                        result += (char)(ch + stepRus);
                    }
                    else if (ch >= 'а' && ch <= 'я')
                    {
                        result += (char)(ch - stepRus);
                    }
                    else
                    {
                        result += ch;
                    }
                }
                Console.WriteLine($"The output string is:\n{result}");
            }

            void FourthProblem()
            {
                Message("counts a number of substrings in the input");
                Console.WriteLine("NOTE: length of substring must not equals 0!\nPlease, enter the string:");
                string str = Console.ReadLine();
                Console.WriteLine("Please, enter the substring:");
                string substr = ReadString();
                Console.WriteLine("The number of {0} in {1} equals: {2}",
                    substr, str, (str.Count() - (str.Replace(substr, "")).Count()) / substr.Count());
            }

            //FirstProblem();
            //SecondProblem();
            //ThirdProblem();
            FourthProblem();
            Console.WriteLine("That's all!\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
