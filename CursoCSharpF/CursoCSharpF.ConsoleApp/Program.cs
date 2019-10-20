using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpF.ConsoleApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.Write("Digite um numero: ");
            Int32 n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um segundo numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int resultado = Soma(n1, n2);
            Console.WriteLine($"O resultado da soma é: {resultado} ");
            resultado = Subtracao(n1, n2);
            Console.WriteLine($"O resultado da subtracao é: {resultado} ");
            resultado = Multiplicacao(n1, n2);
            Console.WriteLine($"O resultado da multiplicacao é: {resultado} ");
            resultado = Divisao(n1, n2);
            Console.WriteLine($"O resultado da divisao é: {resultado} ");
            resultado = Resto(n1, n2);
            Console.WriteLine($"O resultado da resto é: {resultado} ");

            Console.ReadLine();
        }   
        
        static int Soma(int numero1, int numero2)
        {            
            int s = numero1 + numero2;
            return s;
        }
        static int Subtracao(int numero1, int numero2)
        {
            int s = numero1 - numero2;
            return s;
        }
        static int Multiplicacao(int numero1, int numero2)
        {
            int s = numero1 * numero2;
            return s;
        }
        static int Divisao(int numero1, int numero2)
        {
            int s = numero1 / numero2;
            return s;
        }
        static int Resto(int numero1, int numero2)
        {
            int s = numero1 % numero2;
            return s;
        }


    }
}
