using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entrar com as notas da PR1 e PR2 e imprimir a média final.
namespace Exec13
{
    class Program
    {
        static void Main(string[] args)
        {
            double PR1;
            double PR2;

            Console.WriteLine("Insira a PR1:");
            PR1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a PR2:");
            PR2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A média final é: " + (((double)PR1 + (double)PR2) / 2));
            Console.ReadKey();
        }
    }
}
