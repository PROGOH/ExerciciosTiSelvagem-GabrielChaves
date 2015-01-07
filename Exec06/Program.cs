using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler um número inteiro e imprimir seu sucessor e seu antecessor.
namespace Exec06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int anterior;
            int posterior;

            Console.WriteLine("Informe um numero");
            n = int.Parse(Console.ReadLine());

            anterior = n - 1;
            posterior = n + 1;

            Console.WriteLine("O numero anterior ao escolhido é " + anterior);
            Console.WriteLine("O numero posterior ao escolhido é " + posterior);
            Console.ReadKey();
            
        }
    }
}
