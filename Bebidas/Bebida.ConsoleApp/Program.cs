using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebida.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>> Lest's Drink <<<<<<<<<<<<<<<");
            Console.WriteLine("          Welcome to the store!");
            Console.WriteLine("");

            //Method Costumer Registration
            List<string> costumerList = new List<string>();

            for(int i = 0; i < 3; i++)
            {
                string completeName = CustomerRegistration();
                costumerList.Add(completeName);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            //código extra, OrderBy e OrderBy invertido
            //costumerList = costumerList.OrderBy(i => i).ToList();
            //costumerList = costumerList.OrderByDescending(i => i).ToList();


            //código extra, começando por uma letra específica
            //costumerList = costumerList.OrderBy(i => i.StartsWith("B").ToList();

            foreach (string iten in costumerList)
            {
                Console.WriteLine($"- {iten};");
            }

                Console.WriteLine("");
                Console.WriteLine($"See you later , thanks for choosing.");

                Console.ReadKey();

        }

        static string CustomerRegistration()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("And your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("");


            string completeName1 = $"{name} {lastName}";

            return completeName1;
        }
    }
}
