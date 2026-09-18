using System;

class Ex11
{
    static String decodificar(String codificada)
    {
        char[] decodificada = new char[codificada.Length];
        int i, j;

        j = 0;

        for (i = 0; i < codificada.Length;)
        {
            if (codificada[i] == ' ')
            {
                decodificada[j] = codificada[i];
                i = i + 1;
            }
            else
            {
                decodificada[j] = codificada[i + 1];
                i = i + 2;
            }

            j = j + 1;
        }

        return new String(decodificada, 0, j);
    }

    static void Main()
    {
        String codificada = Console.ReadLine() ?? "";
        Console.WriteLine(decodificar(codificada));
    }
}
