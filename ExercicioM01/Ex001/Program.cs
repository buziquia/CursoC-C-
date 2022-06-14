using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 4);

            //Primeira Parte
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Meu ");
            Console.ResetColor();

            //Segunda Parte
            Thread.Sleep(1000);
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write(" Brasil ");
            Console.ResetColor();

            //Terceira Parte
            Thread.Sleep(1000);
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write(" Brasileiro ");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}