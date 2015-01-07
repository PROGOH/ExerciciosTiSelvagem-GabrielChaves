using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler dois números inteiros e imprimi-los.
namespace Exec05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Informe o primeiro numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("O numero A é: " + a);
            Console.WriteLine("O numero B é: " + b);

            Console.ReadKey();
           

        }
    }
}
