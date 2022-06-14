using System;

namespace ExpressoesMistas
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            float n1 = 0f;
            float n2 = 0f;
            Console.Write("Primeira nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n1);
            Console.Write("Segunda nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n2);
            //cálculo da média e situações
            float media = (n1 + n2) / 2;
            bool sit01 = media >= 0 && media < 4.0;
            bool sit02 = media >= 4.0 && media < 7.0;
            bool sit03 = media >= 7.0 && media <= 10.0;
            //Mostrando resultados
            Console.WriteLine($"A média do aluno foi {media:F1}");
            Console.WriteLine($"Aluno está reprovado? {sit01}");
            Console.WriteLine($"Aluno está em recuperação? {sit02}");
            Console.WriteLine($"Aluno está aprovado? {sit03}");
        }
    }
}
