using System;

class Ex1180
{
    static void Main()
    {
        int n, i, menor, posicao;

        n = int.Parse(Console.ReadLine() ?? "0");
        int[] x = new int[n];
        string[] valores = (Console.ReadLine() ?? "").Split(' ');

        for (i = 0; i < n; i++)
        {
            x[i] = int.Parse(valores[i]);
        }

        menor = x[0];
        posicao = 0;

        for (i = 1; i < n; i++)
        {
            if (x[i] < menor)
            {
                menor = x[i];
                posicao = i;
            }
        }

        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Posicao: " + posicao);
    }
}
