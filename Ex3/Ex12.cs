using System;
using System.Globalization;

class Ex12
{
    static double calcularNotaFinal(double[] notas)
    {
        double soma = 0;
        double maior = notas[0];
        double menor = notas[0];

        for (int i = 0; i < notas.Length; i++)
        {
            soma = soma + notas[i];

            if (notas[i] > maior)
            {
                maior = notas[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
            }
        }

        return soma - maior - menor;
    }

    static void Main()
    {
        string[] valores = (Console.ReadLine() ?? "").Split(' ');
        double[] notas = new double[5];

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
        }

        double notaFinal = calcularNotaFinal(notas);
        Console.WriteLine(notaFinal.ToString("F1", CultureInfo.InvariantCulture));
    }
}
