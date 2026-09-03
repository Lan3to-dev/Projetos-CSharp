using System;
// importe a biblioteca
using BibliotecaMatriz;

class Ex04
{
    static void Main()
    {
        Console.Write("Digite o número de linhas da matriz: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas da matriz: ");
        int colunas = int.Parse(Console.ReadLine());
        // declare a matriz

        int[,] matriz = new int[linhas, colunas];

        // Testando a função leia
        Console.WriteLine("\nDigite os elementos da matriz:");
        // chame a função
        Matriz.lerMatriz(matriz);
        Console.WriteLine("\nMatriz digitada:");
        // chame a função
        Matriz.mostrarMatriz(matriz);
        // chame a função
        Console.ReadKey();
        // Testando a função gera
        Console.WriteLine("\nGerando uma matriz com valores aleatórios...");
        // chame a função
        Matriz.gerarMatriz(matriz);
        Console.WriteLine("\nMatriz gerada aleatoriamente:");
        // chame a função
        Matriz.mostrarMatriz(matriz);
        Console.ReadKey();
    }
}