using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovLab3_2
{
    internal class Program
    {
        struct BankAccountInfo
        {
            public int number;
            public int balance;
            public void toString()
            {
                Console.WriteLine($"Number of the card: {number}, its balanse: {balance}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Description: create bank account info struct, make an instance of this and print it:\n");
            BankAccountInfo account = new BankAccountInfo();
            account.number = 12345;
            account.balance = 67890;
            account.toString();
            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}
