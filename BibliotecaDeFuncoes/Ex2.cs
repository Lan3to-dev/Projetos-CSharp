using System;
using BibliotecaFuncoes;

class Ex2
{
    static int contarImpares(int[] vetor)
    {
        int contadorImpares = 0;
        //percorrer o vector e contar impares
        //retornar
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                contadorImpares++;
            }
        }

        return contadorImpares;
    }
    static void Main()
    {
        int n, qtdImpares;
        Console.Write("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        BibliotecaVector.gerarVetor(meuArray);
        BibliotecaVector.mostrarVetor(meuArray);
        qtdImpares = contarImpares(meuArray);//chamar da funcao
        Console.WriteLine("\nQuantidade de impares: " +qtdImpares);
    }
}