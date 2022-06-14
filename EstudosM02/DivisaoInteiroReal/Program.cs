using System;

namespace DivisaoInteiroReal
{
    class Divisao
    {
        static void Main(string[] args) 
        {
            int n1 = 0;
            int n2 = 0;

            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out n2);

            float res = (float)n1 / (float)n2;
            Console.WriteLine($"O resultado de {n1} / {n2} = {res:F1}");

            Console.ReadLine();
        }
    }
}