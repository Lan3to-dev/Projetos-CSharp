using System;

class Ex10
{
    static int[] contarFaces(int[] lancamentos)
    {
        int[] ocorrencias = new int[6];

        for (int i = 0; i < lancamentos.Length; i++)
        {
            ocorrencias[lancamentos[i] - 1] = ocorrencias[lancamentos[i] - 1] + 1;
        }

        return ocorrencias;
    }

    static void Main()
    {
        int n;

        Console.Write("Digite a quantidade de lançamentos: ");
        n = int.Parse(Console.ReadLine() ?? "0");

        int[] lancamentos = new int[n];

        for (int i = 0; i < lancamentos.Length; i++)
        {
            Console.Write("Resultado do lançamento " + (i + 1) + ": ");
            lancamentos[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        int[] ocorrencias = contarFaces(lancamentos);

        for (int i = 0; i < ocorrencias.Length; i++)
        {
            Console.WriteLine("Face " + (i + 1) + ": " + ocorrencias[i] + " ocorrência(s)");
        }
    }
}
