using System;
using BibliotecaMatriz;

class Ex01
{
    static void Main()
    {
        int linhas, colunas, maior;

        Console.Write("Digite o número de linhas da matriz: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas da matriz: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        Matriz.lerMatriz(matriz);
        maior = Matriz.maiorValor(matriz);

        Console.WriteLine("Maior valor: " + maior);
    }
}
