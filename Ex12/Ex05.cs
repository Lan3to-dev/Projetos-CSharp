using System;
using System.IO;

class Ex05
{
    static int[,] carregarMatriz(string caminhoArquivo)
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

    static int verificarOcorrencias(int[,] matriz, int valorProcurado)
    {
        int quantidade = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == valorProcurado)
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

        Console.Write("Digite o código que deseja contar: ");
        codigo = int.Parse(Console.ReadLine());

        quantidade = verificarOcorrencias(mapa, codigo);

        Console.WriteLine("Quantidade de ocorrências do código " + codigo + ": " + quantidade);
    }
}
