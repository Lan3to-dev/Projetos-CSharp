using System;

class Ex05
{
    static int procurarNumero(int[] vetor, int numero)
    {
        int posicao = -1;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero && posicao == -1)
            {
                posicao = i;
            }
        }

        return posicao;
    }

    static void Main()
    {
        int n, numero, posicao;
        Random aleatorio = new Random();

        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor = new int[n];

        Console.WriteLine("Vetor gerado:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(1, 101);
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Digite o número que deseja procurar: ");
        numero = int.Parse(Console.ReadLine() ?? "0");

        posicao = procurarNumero(vetor, numero);

        if (posicao == -1)
        {
            Console.WriteLine("Número não encontrado.");
        }
        else
        {
            Console.WriteLine("Número encontrado na posição " + posicao + ".");
        }
    }
}
