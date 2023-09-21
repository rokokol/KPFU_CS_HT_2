using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymakovHT3_1
{
    internal class Program
    {
        enum Universities
        {
            KPFU,
            KAI,
            KSTU
        }

        struct Employee
        {
            public string name;
            public Universities university;
            public void toString()
            {
                Console.WriteLine($"Name: {name}, university: {university}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Description: create enum and employee, create their instances and print them\n");
            Employee employee = new Employee();
            employee.name = "Антон";
            employee.university = Universities.KAI;
            employee.toString();
            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}
