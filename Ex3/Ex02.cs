using System;

class Ex02
{
    static int contarImpares(int[] vetor)
    {
        int quantidade = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                quantidade = quantidade + 1;
            }
        }

        return quantidade;
    }

    static void Main()
    {
        int n, quantidade;

        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor = new int[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Vetor[" + i + "]: ");
            vetor[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        quantidade = contarImpares(vetor);
        Console.WriteLine("Quantidade de números ímpares: " + quantidade);
    }
}
