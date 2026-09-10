using System;

class Ex08
{
    static void Main()
    {
        int n, i, x, y;
        bool repetiu;
        int[,] mapa = new int[501, 501];

        n = int.Parse(Console.ReadLine());
        repetiu = false;

        for (i = 0; i < n; i++)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            if (mapa[x, y] == 1)
            {
                repetiu = true;
            }
            else
            {
                mapa[x, y] = 1;
            }
        }

        if (repetiu == true)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
