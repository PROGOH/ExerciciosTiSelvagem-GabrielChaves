using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: Soma.
namespace Exec08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma:" + ((int)a + (int)b));
            Console.ReadKey();


        }
    }
}
