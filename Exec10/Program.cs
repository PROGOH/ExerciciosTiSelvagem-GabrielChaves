using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ler um número real(numero com virgula) e imprimir a terça parte deste número.
namespace Exec10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Insira um numero");
            n = double.Parse(Console.ReadLine());
            //Teste de modificação

            Console.WriteLine("A terça parte de seu numero é: " + ((double)n / 3));
            Console.ReadKey();
        }
    }
}
