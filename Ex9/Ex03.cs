using System;

class Ex03
{
    static void gerarMatriz(int[,] matriz)
    {
        Random random = new Random();

        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = random.Next(0, 100);
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
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matriz = new int[3, 3];

        gerarMatriz(matriz);

        Console.WriteLine("Matriz gerada:");

        mostrarMatriz(matriz);
    }
}