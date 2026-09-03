using System;

class Ex1172
{
    static void Main()
    {
        int[] x = new int[10];
        int i;

        for (i = 0; i < 10; i++)
        {
            x[i] = int.Parse(Console.ReadLine() ?? "0");

            if (x[i] <= 0)
            {
                x[i] = 1;
            }
        }

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("X[" + i + "] = " + x[i]);
        }
    }
}