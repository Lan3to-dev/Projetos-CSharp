using System;
using BibliotecaMatriz;
using System.IO;

class Ex03
{
    public static int[,] carregarMatriz(string caminhoArquivo)
    {
        string[] linhas = File.ReadAllLines(caminhoArquivo);
        int numLinhas = linhas.Length;
        int numColunas = linhas[0].Split(',').Length;

        int[,] matriz = new int[numLinhas, numColunas];

        for (int i = 0; i < numLinhas; i++)
        {
            string[] valores = linhas[i].Split(',');

            for (int j = 0; j < numColunas; j++)
            {
                matriz[i, j] = int.Parse(valores[j]);
            }
        }

        return matriz;
    }

    public static int verificarOcorrencias(int[,] matriz, int codigo)
    {
        int quantidade = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == codigo)
                {
                    quantidade = quantidade + 1;
                }
            }
        }

        return quantidade;
    }

    static void Main()
    {
        int codigo, quantidade;
        int[,] mapa = carregarMatriz("ocorrencias.csv");

        Console.WriteLine("Mapa de ocorrências:");
        Matriz.mostrarMatriz(mapa);

        Console.Write("Digite o código da ocorrência que deseja pesquisar: ");
        codigo = int.Parse(Console.ReadLine());

        quantidade = verificarOcorrencias(mapa, codigo);

        Console.WriteLine("Quantidade total: " + quantidade);
        Console.WriteLine("Setores afetados:");

        for (int i = 0; i < mapa.GetLength(0); i++)
        {
            for (int j = 0; j < mapa.GetLength(1); j++)
            {
                if (mapa[i, j] == codigo)
                {
                    Console.WriteLine("[" + i + ", " + j + "]");
                }
            }
        }
    }
}