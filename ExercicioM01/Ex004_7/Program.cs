using System;

namespace Ex004_7
{
    public class Program
    {
        static void Main()
        {
            int ini, fim;
            Console.WriteLine("\nSORTEADOR DE NÚMEROS!!");
            Console.WriteLine("-------------------------");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out ini);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);

            Console.SetCursorPosition(0, 4);
            Console.Write("Sortenando....");
            Thread.Sleep(2000);

            Random gerador = new Random();
            int num = gerador.Next(ini, fim +1);
            Console.SetCursorPosition(0, 4);
            Console.WriteLine($"Entre {ini} e {fim} sortiei o valor {num}");
        }
    }
}
