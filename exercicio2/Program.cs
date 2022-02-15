using System;

namespace Ex2L3LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escrever um algoritmo que gera e escreve os números ímpares entre 100
            e 200.*/
            
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i + " é impar.");
            }
            Console.ReadKey();
                
        }
    }
}
