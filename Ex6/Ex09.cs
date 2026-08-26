using System;

class Ex09
{
    static void Main()
    {
        Console.Write("Digite o primeiro texto: ");
        string texto1 = Console.ReadLine() ?? "";

        Console.Write("Digite o segundo texto: ");
        string texto2 = Console.ReadLine() ?? "";

        // Complete a solução utilizando:
        // Length, ToUpper() e string.Compare()
        string texto1Maiusculo = texto1.ToUpper();
        string texto2Maiusculo = texto2.ToUpper();
        int resultado;

        Console.WriteLine("Tamanho do primeiro texto: " + texto1.Length);
        Console.WriteLine("Tamanho do segundo texto: " + texto2.Length);
        Console.WriteLine("Primeiro texto em maiúsculas: " + texto1Maiusculo);
        Console.WriteLine("Segundo texto em maiúsculas: " + texto2Maiusculo);

        resultado = string.Compare(texto1Maiusculo, texto2Maiusculo);

        if (resultado == 0)
            Console.WriteLine("Os textos são equivalentes.");
        else
            Console.WriteLine("Os textos não são equivalentes.");

    }
}
