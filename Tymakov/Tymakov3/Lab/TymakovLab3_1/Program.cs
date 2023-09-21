using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovLab3_1
{
    internal class Program
    {
        enum BankAccountType
        {
            Saving,
            Current
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Description: create bank account type enum, make an instance of this and print it:\n");
            BankAccountType type = BankAccountType.Current;
            Console.WriteLine($"Bank account type is: {type}");
            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}
