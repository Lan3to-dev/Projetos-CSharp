using System;

class Ex01
{
    static int somarElementos(int[] vetor)
    {
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma = soma + vetor[i];
        }

        return soma;
    }

    static void Main()
    {
        int n, soma;

        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor = new int[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Vetor[" + i + "]: ");
            vetor[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        soma = somarElementos(vetor);
        Console.WriteLine("Soma dos elementos: " + soma);
    }
}
