using System;

namespace Ex5L3LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
            valores do cálculo de A! e o seu resultado. */

            Console.WriteLine("Calculadora de fatorial.");
            Console.WriteLine("Digite um número: ");
            string strA = Console.ReadLine();
            int A = Convert.ToInt32(strA);

            int i = A;
            int resultado = 1;

            for (i = A; i > 0; i--)
            {
                resultado = i * resultado;
            }
           
            Console.WriteLine(A + "! = " + resultado);
            Console.WriteLine("Pressione enter para sair.");
            Console.ReadKey();

    }
    }
}
