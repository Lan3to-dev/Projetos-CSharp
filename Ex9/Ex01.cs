using System;

class Ex01
{
    static void Main()
    {
        int linhas = 3;
        int colunas = 3;

        int[,] matriz = new int[linhas, colunas];

        Console.WriteLine("Digite os elementos da matriz:");

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Matriz:");

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}