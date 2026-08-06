using System;

class Ex1064
{
    static void Main()
    {
        double num, soma, media;
        int positivos, i;
        soma = 0;
        positivos = 0;
        for (i = 1; i <= 6; i++)
        {
            num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                positivos = positivos + 1;
                soma = soma + num;
            }
        }
        media = soma / positivos;
        Console.WriteLine(positivos + " valores positivos");
        Console.WriteLine($"{media:F1}");
    }
}
