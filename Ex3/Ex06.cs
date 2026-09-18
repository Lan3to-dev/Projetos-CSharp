using System;

class Ex06
{
    static int[] multiplicarVetores(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[vetor1.Length];

        for (int i = 0; i < vetor1.Length; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        return resultado;
    }

    static void Main()
    {
        int n;

        Console.Write("Digite o tamanho dos vetores: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];

        Console.WriteLine("Digite os elementos do primeiro vetor:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Vetor 1[" + i + "]: ");
            vetor1[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("Digite os elementos do segundo vetor:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Vetor 2[" + i + "]: ");
            vetor2[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        int[] resultado = multiplicarVetores(vetor1, vetor2);

        Console.WriteLine("Vetor resultante:");

        for (int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i] + " ");
        }

        Console.WriteLine();
    }
}
