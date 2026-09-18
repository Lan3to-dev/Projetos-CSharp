using System;

class Ex09
{
    static char[] gerarComplementar(char[] dna)
    {
        char[] complementar = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            if (dna[i] == 'A')
            {
                complementar[i] = 'T';
            }
            else if (dna[i] == 'T')
            {
                complementar[i] = 'A';
            }
            else if (dna[i] == 'C')
            {
                complementar[i] = 'G';
            }
            else
            {
                complementar[i] = 'C';
            }
        }

        return complementar;
    }

    static void Main()
    {
        string texto;

        Console.Write("Digite a fita de DNA: ");
        texto = Console.ReadLine() ?? "";

        char[] dna = texto.ToUpper().ToCharArray();
        char[] complementar = gerarComplementar(dna);

        Console.WriteLine("Fita de DNA: " + new string(dna));
        Console.WriteLine("Fita complementar: " + new string(complementar));
    }
}
