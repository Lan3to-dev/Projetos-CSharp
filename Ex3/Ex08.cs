using System;

class Ex08
{
    static char[] inverterVetor(char[] vetor)
    {
        char[] invertido = new char[vetor.Length];
        int j = 0;

        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            invertido[j] = vetor[i];
            j = j + 1;
        }

        return invertido;
    }

    static void Main()
    {
        string texto;

        Console.Write("Digite os caracteres: ");
        texto = Console.ReadLine() ?? "";

        char[] vetor = texto.ToCharArray();
        char[] invertido = inverterVetor(vetor);

        Console.WriteLine("Quantidade de elementos: " + vetor.Length);
        Console.WriteLine("Vetor invertido: " + new string(invertido));
    }
}
