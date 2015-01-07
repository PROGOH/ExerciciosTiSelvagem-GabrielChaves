using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler nome, endereço e telefone e imprimi-los.
namespace Exec07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string endereco;
            string telefone;

            Console.WriteLine("Insira o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Insira seu endereço");
            endereco = Console.ReadLine();
            Console.WriteLine("Insira seu telefone");
            telefone = Console.ReadLine();

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Endereço: " + endereco);
            Console.WriteLine("Telefone: " + telefone);
            Console.ReadKey();
        }
    }
}
