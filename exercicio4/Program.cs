using System;

namespace Ex4L3LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*• Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
            calcule a tabuada de N.
                • Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
            10N.*/

            Console.WriteLine("Todo mundo olha uma colinha da tabuada de vez em quando.");
            Console.WriteLine("Digite um número inteiro:");
            string strN = Console.ReadLine();
            int N = Convert.ToInt32(strN);

            int i = 1;
            
            int resultado = 0;
            for (i = 1; i <= 10; i++)
            {
                resultado = N * i;
                Console.WriteLine(i + " X " + N + " = " + resultado);
            }
            Console.WriteLine("Pressione enter para sair.");
            Console.ReadKey();
        }
    }
}
