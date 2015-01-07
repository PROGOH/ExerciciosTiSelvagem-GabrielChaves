using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entrar com um nome e imprimir:
//Todo o nome: 
//Primeiro Caractere: 
//Ultimo Caractere: 
//Do Primeiro ate o Terceiro: 
//Quarto Caractere: 
//Todos menos o Primeiro: 
//Os Dois Últimos:

namespace Exec14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Insira seu nome");
            nome = Console.ReadLine();
       
            Console.WriteLine("Todo o nome: " + nome);
            Console.WriteLine("Primeiro Caractere: " + nome.Substring(0,1));
            Console.WriteLine("Ultimo Caractere: " + nome.Last());
            Console.WriteLine("O Quarto Caracter: {0}", nome.Substring(3, 1));
            Console.WriteLine("Todos menos o primeiro: {0}", nome.Substring(1, nome.Length - 1));
            Console.WriteLine("Os dois ultimos: {0} ", nome.Substring(nome.Length - 2, 2));
           
            Console.ReadKey();

            
            


        }
    }
}
