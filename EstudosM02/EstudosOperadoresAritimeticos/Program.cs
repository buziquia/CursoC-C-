using System;

namespace EstudosOperadoresAritimeticos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exemplos de Operadores aritiméticos
            int op1 = 0;
            int op2 = 0;
            //Entrada de dados 
            Console.Write("Digite o primeiro operador: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo valor: ");
            int.TryParse(Console.ReadLine(), out op2);
            // Realizando as operações
            Console.WriteLine($"Calculando +{op1} = {+op1}"); // identidade
            Console.WriteLine($"Calculando -{op1} = {-op1}"); // negação aritimética
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}"); // adição
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}"); // subtração
            Console.WriteLine($"Calculando {op1} x {op2} = {op1 * op2}"); // multiplicação
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {op1 / op2} (obs:divisão inteiro)"); // divisão (inteira)
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}"); // resto da divisão

            Console.ReadKey();
        }
    }
}