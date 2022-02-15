using System;

class Program
{
    static void Main(string[] args)
    {
        /*Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
        programa deverá calcular e mostrar:
        a. A menor altura do grupo;
        b. A maior altura do grupo;*/

        float[] alturas = new float[15];

        float maior = alturas[0];
        float menor = 1005775; //Isso aqui é a mais pura gambiarra.
        int i = 0;

        do
        {
            Console.WriteLine("Digite a altura:");
            string straltura = Console.ReadLine();
            alturas[i] = float.Parse(straltura);

            if (alturas[i] <= menor)
                menor = alturas[i];

            if (alturas[i] > maior)
                maior = alturas[i];

            i++;
        }


        while (i < 15);
        string strmenorfinal = Convert.ToString(menor);
        string strmaiorfinal = Convert.ToString(maior);

        Console.WriteLine("A pessoa com a menor altura do grupo tem " + strmenorfinal + " m.");
        Console.WriteLine("A pessoa com a maior altura do grupo tem " + strmaiorfinal + " m.");
        Console.ReadKey();

    }
}