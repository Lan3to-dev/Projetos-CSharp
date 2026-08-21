using System;

class Ex2
{
    static void Main()
    {
        String nome;
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        char[] nomeArray = nome.ToCharArray();
        nomeArray[0] = (char)(nomeArray[0] - 32);
        Console.WriteLine("Nome: " + new string(nomeArray));

    }
}