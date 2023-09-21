using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksFrom1to8
{
    internal class Program
    {
        static int number = 1;
        static Random RANDOM = new Random();

        static void Message(string message)
        {
            Console.WriteLine("\nLet's check problem #{0}\nThis program {1}\nPress any to continue...", number++, message);
            Console.ReadKey();
        }

        static int CalculateBarcodeSum(string barcode)
        {
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += int.Parse(barcode[i].ToString());
                }
                else
                {
                    evenSum += int.Parse(barcode[i].ToString());
                }
            }
            return (10 - ((3 * oddSum + evenSum) % 10)) % 10;
        }

        static ConsoleColor RandomColor()
        {
            return (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue(RANDOM.Next() % 16);
        }

        static void Error()
        {
            Console.WriteLine("Wrong input. Please, try again:");
        }

        /**
        * Function read the input double and offers to user to try again if he was wrong
        * nonZero - input != 0; only positive - input must be >= 0
        * maxValue - max value that user can input
        */
        static double ReadDouble(bool onlyPositive, bool nonZero, double maxValue)
        {
            double result = 0;
            bool cond = true;
            while (cond)
            {
                bool convert = double.TryParse(Console.ReadLine().Replace(",", "."), out result);
                bool onlyPositiveFlag = result >= 0 || !onlyPositive;
                bool nonZeroFlag = result != 0 || !nonZero;
                
                if (onlyPositiveFlag && nonZeroFlag && convert && result < maxValue)
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

        /**
         * Read string which length must be lesser or equal than maxLength and bigger or equals than minSize
         * if minSize < 0, it may be any number
         * if maxSize < 0, it may be any number
         */
        static string ReadString(int MinSize, int maxLength)
        {
            string input = "";
            bool cont = true;
            while (cont)
            {
                input = Console.ReadLine();
                if ((maxLength < 0 || input.Length >= maxLength) && (maxLength < 0 || input.Length <= maxLength))
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

        static string ReadString()
        {
            return ReadString(1,    -1);
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

            void FifthProblem()
            {
                Message("count how many whisky bottles of duty-free trade you will" +
                    "\nneed to buy to save compared to the usual average price actually cover the cost of your holiday");

                Console.WriteLine("NOTE: you should not write sings like % or £ in the end of number\n" +
                    "Please, enter the normal price of whisky (in £):");
                double normPrice = ReadDouble(true, true, double.PositiveInfinity);
                Console.WriteLine("Please write the discount (in %):");
                double discount = ReadDouble(true, true, 100d);
                Console.WriteLine("Please, enter holiday's price (in £):");
                double holidayPrice = ReadDouble(true, true, double.PositiveInfinity);
                double salePrice = (normPrice / 100d) * discount;
                Console.WriteLine("The count bottles of whisky that you should buy to have a enough money is: {0}",
                    (int)(holidayPrice / salePrice));
            }

            void SixthProblem()
            {
                Message("reproduces Harry Potter’s Conversation and Tom Reddle’s Diary");

                Console.WriteLine("What's your name?");
                Console.WriteLine($"Welcome, {ReadString()}!\n(You should ask: \"Do you know something about the secret room?\")");

                bool cond = true;
                while (cond)
                {
                    string input = ReadString();
                    if (input.Equals("Do you know something about the secret room?"))
                    {
                        cond = false;
                    }
                    else
                    {
                        Console.WriteLine("I do not understand you. Couldn't you repeat, please?");
                    }
                }

                Console.WriteLine("Sure\n(You should ask: \"Might you tell me something about it?\")");
                cond = true;
                while (cond)
                {
                    string input = ReadString();
                    if (input.Equals("Might you tell me something about it?"))
                    {
                        cond = false;
                    }
                    else
                    {
                        Console.WriteLine("I do not understand you. Couldn't you repeat, please?");
                    }
                }

                Console.WriteLine("No.");
                void Count(Object obj)
                {
                    Console.Write('.');
                }
                Timer timer = new Timer(Count, null, 1250, 1250);
                Thread.Sleep(5000);
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                Console.BackgroundColor = RandomColor();
                Console.Clear();
                Console.WriteLine("But I can show it");
                Console.ResetColor();
            }

            void SeventhProblem()
            {
                string MASK = "The control sum of {0} is: {1}\n";
                Message("first calculates control sun of random barcode, then calculates control sum of input barcode");

                StringBuilder randBarcode = new StringBuilder();
                for (int i = 0; i < 13; i++)
                {
                    randBarcode.Append((RANDOM.Next() % 10).ToString());
                }
                Console.WriteLine(MASK, randBarcode, CalculateBarcodeSum(randBarcode.ToString()));
                Console.WriteLine("NOTE: barcode is a string that consist of 12 digits\nPlease, enter the barcode:");
                string barcode = ReadString(12, 12);
                Console.WriteLine(MASK, barcode, CalculateBarcodeSum(barcode));
            }

            FirstProblem();
            SecondProblem();
            ThirdProblem();
            FourthProblem();
            FifthProblem();
            SixthProblem();
            SeventhProblem();
            Console.WriteLine("That's all!\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
