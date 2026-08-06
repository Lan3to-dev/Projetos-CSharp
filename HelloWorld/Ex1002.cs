using System;

class Ex1002
{
    static void Main(string[] args)
    {
        double raio, area;
        //Console.WriteLine("entre com o valor do raio");
        raio = double.Parse(Console.ReadLine());
        area = 3.14159 * raio * raio;
        Console.WriteLine("A=" + area.ToString("F4"));
    }
}
