using System;

class Ex1005
{
    static void Main()
    {
        double num1, num2, media;
        //Console.WriteLine("entre com dois valores");
        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        media = (num1 * 3.5 + num2 * 7.5) / 11;
        Console.WriteLine($"MEDIA = {media:F5}");
    
    }
}