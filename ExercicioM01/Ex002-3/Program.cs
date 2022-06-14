using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero Real ");
            float num;
            float.TryParse(Console.ReadLine(), out num);

            int n1 = (int)num;
            int n2 = Convert.ToInt16(num);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Voçê digitou o valor {num:n}");
            Console.WriteLine($"A parte inteira do número é {n1:D}");
            Console.WriteLine($"Arredondando, temos o número {n2:D}");
            Console.ReadKey();

        }
    }
}