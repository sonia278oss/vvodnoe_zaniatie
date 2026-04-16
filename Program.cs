using System;
class Program
{
    static void Main()
    {
        double x = 4.3;
        double numerator = 1 + Math.Sqrt(Math.Abs(3 - Math.Pow(x, 2)));
        double denominator = Math.Atan(Math.Pow(x, 2));
        double secondPart = Math.Exp(Math.Sin(Math.Sqrt(x)));
        double y = (numerator / denominator) - secondPart;
        Console.WriteLine($"Результат y = {y:F4}");
    }
}
