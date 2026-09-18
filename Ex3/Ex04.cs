using System;

class Ex04
{
    static double menorElemento(double[] vetor)
    {
        double menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
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
        double menor;

        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        double[] vetor = new double[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Vetor[" + i + "]: ");
            vetor[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        menor = menorElemento(vetor);

        Console.WriteLine("Vetor:");
        mostrarVetor(vetor);
        Console.WriteLine("Menor elemento: " + menor);
    }
}
