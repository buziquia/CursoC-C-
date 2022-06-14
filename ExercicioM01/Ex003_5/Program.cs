using System;

namespace Ex003_5
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Em que ano voçê nasceu? ");
            int nasc;
            int.TryParse(Console.ReadLine(), out nasc);
            int atual = DateTime.Now.Year;
            int idade = atual - nasc;

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Estamos atualmente no ano de {atual}");
            Console.WriteLine($"Se voçê nasceu em {nasc}, vai ter {idade} anos.");       
        }
    }
}
