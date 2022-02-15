using System;

namespace Ex3L3LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolver um algoritmo que efetue a soma de todos os números
            ímpares que são múltiplos de três e que se encontram no conjunto dos
            números de 1 até 500.*/

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            { 
                if (i % 2 != 0 && i % 3 == 0)
                {
                    
                    soma = soma + i;
                }
                
            }
            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
