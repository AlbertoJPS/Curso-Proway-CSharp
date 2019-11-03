using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio1.Class;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Nota 10");
            Console.WriteLine("");
          

            Dados dados = new Dados();

            for (int i = 0; i < 1; i++)
            {
                Pessoa p = RegistrarCliente();
                dados.Salvar(p);

            }

            List<Pessoa> listaClientes = dados.LeiaTodos();

            foreach (Pessoa item in listaClientes)
            {
                Console.WriteLine($"{item.Nome} {item.SobreNome} \n{item.Idade} anos \nCPF: {item.CPF}");
            }
       
           
            Console.ReadKey();


        }
        static Pessoa RegistrarCliente()
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine(pessoa1.Nome);
            Console.WriteLine(pessoa1.SobreNome);
            Console.WriteLine(pessoa1.Idade);
            Console.WriteLine(pessoa1.CPF);

            Console.WriteLine("Digite seu nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu Sobrenome: ");
            pessoa1.SobreNome = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            pessoa1.Idade = Console.ReadLine();
            Console.WriteLine("Informe seu CPF:");
            pessoa1.CPF = Console.ReadLine();


            return pessoa1;
        }
    }
}

