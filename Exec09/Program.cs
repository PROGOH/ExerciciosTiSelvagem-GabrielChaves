using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Digite o valor de a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos produtos é: " + ((int)a + (int)b));
            Console.ReadKey();
        }
    }
}
