using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado. 
namespace Exec11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Insira o valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Média: " + (((double)a + (double)b) / 2));
            Console.ReadKey();

        }
    }
}
