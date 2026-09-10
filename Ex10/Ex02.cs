using System;
using BibliotecaMatriz;

class Ex02
{
    static void Main()
    {
        int linhas, colunas, menor;

        Console.Write("Digite o número de linhas da matriz: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas da matriz: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        Matriz.lerMatriz(matriz);
        menor = Matriz.menorValor(matriz);

        Console.WriteLine("Menor valor: " + menor);
    }
}
