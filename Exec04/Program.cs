using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar um algoritmo que imprima a média aritmética entre os números 8, 9 e 7.
namespace Exec04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 8;
            int n2 = 9;
            int n3 = 7;
            int soma;
            int media;

            soma = n1 + n2 + n3;
            media = soma / 3;

            Console.WriteLine("A média de 8,9,7 é : " + media);
            Console.ReadKey();

        }
    }
}
