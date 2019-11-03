using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bebida.ConsoleApp.Class;

            //ctrl+k+u desconenta área selecionada
            //ctrl+k+c conenta área selecionada
            //ctrl+shift+b compilar,e verificar erros

            //código extra, OrderBy e OrderBy invertido
            //costumerList = costumerList.OrderBy(i => i).ToList();
            //costumerList = costumerList.OrderByDescending(i => i).ToList();

            //código extra, começando por uma letra específica
            //costumerList = costumerList.OrderBy(i => i.StartsWith("B").ToList();

namespace Bebida.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>> Lest's Drink <<<<<<<<<<<<<<<");
            Console.WriteLine("          Welcome to the store!");
            Console.WriteLine("");

            Data data = new Data();

            for(int i = 0; i < 3; i++)
            {
                Person p = CustomerRegistration();
                data.ToSave(p);
                
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            List<Person> costumerList = data.ReadAll();

            foreach (Person iten in costumerList)
            {
                Console.WriteLine($"- {iten.Name} {iten.LastName};");
            }
            Console.WriteLine("");
            Console.WriteLine($"See you later , thanks for choosing.");

            Console.ReadKey();
        }

        static Person CustomerRegistration()
        {
            Person person1 = new Person();

            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.LastName);

            Console.Write("Enter your name: ");
            person1.Name = Console.ReadLine();
            Console.Write("And your last name: ");
            person1.LastName = Console.ReadLine();
            Console.WriteLine("");

            return person1;
        }
    }
}