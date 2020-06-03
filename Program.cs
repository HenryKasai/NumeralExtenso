using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira um número inteiro.");
            int número = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Você digitou o número {número.ToWords()}.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
