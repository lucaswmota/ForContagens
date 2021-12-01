using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForContagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contando até 100 em modo crescente");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contando de 100 a 1 em modo Decrescente");
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contando somente os pares até 100");
            for (int i = 0; i <= 100; i += 2) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contando os Ímpares até 100");
            for (int i = 1; i <= 100; i += 2) 
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
