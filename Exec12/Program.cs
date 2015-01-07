using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1%. 
namespace Exec12
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            double novoSaldo;

            Console.WriteLine("Qual o saldo atual?");
            saldo = double.Parse(Console.ReadLine());
            novoSaldo = (0.1 * saldo) + saldo;

            Console.WriteLine("o novo saldo é: " + (double)novoSaldo);
            Console.ReadKey();


        }
    }
}
