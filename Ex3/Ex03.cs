using System;

class Ex03
{
    static double maiorElemento(double[] vetor)
    {
        double maior = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }

        return maior;
    }

    static void mostrarVetor(double[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int n;
        double maior;

        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        double[] vetor = new double[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Vetor[" + i + "]: ");
            vetor[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        maior = maiorElemento(vetor);

        Console.WriteLine("Vetor:");
        mostrarVetor(vetor);
        Console.WriteLine("Maior elemento: " + maior);
    }
}
