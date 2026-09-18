using System;

class Ex07
{
    static int contarOcorrencias(int[] vetor, int valor)
    {
        int quantidade = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                quantidade = quantidade + 1;
            }
        }

        return quantidade;
    }

    static void Main()
    {
        int n, valor, quantidade;

        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor = new int[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Vetor[" + i + "]: ");
            vetor[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        Console.Write("Digite o valor que deseja verificar: ");
        valor = int.Parse(Console.ReadLine() ?? "0");

        quantidade = contarOcorrencias(vetor, valor);

        Console.WriteLine("Elementos do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("O valor aparece " + quantidade + " vez(es).");
    }
}
