using System;
using BibliotecaFuncoes;

class Program
{
    static void Main()
    {
        int[] meuArray = new int[10];
        BibliotecaVector.gerarVetor(meuArray);
        BibliotecaVector.mostrarVetor(meuArray);
        Console.ReadKey();
    }
}