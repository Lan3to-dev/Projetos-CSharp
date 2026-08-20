using System;

class ExListaSala2
{
    static void Main()
    {
        int[] vetor = new int[5];
        int i, numero;
        bool achou;

        achou = false;

        for (i = 0; i < 5; i++)
        {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o número para procurar: ");
        numero = int.Parse(Console.ReadLine());

        for (i = 0; i < 5; i++)
        {
            if (vetor[i] == numero)
            {
                achou = true;
            }
        }

        if (achou == true)
        {
            Console.WriteLine("Número encontrado");
        }
        else
        {
            Console.WriteLine("Número não encontrado");
        }
    }
}
