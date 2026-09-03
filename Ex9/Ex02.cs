using System;

class Ex02
{
    static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void mostrarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{matriz[i, j],3}| ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matriz = new int[3, 3];

        lerMatriz(matriz);

        Console.WriteLine("Matriz:");

        mostrarMatriz(matriz);
    }
}