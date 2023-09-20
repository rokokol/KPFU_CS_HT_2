using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app asks your name and then welcome you");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLi kne($"Welcome, dear {name}!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
