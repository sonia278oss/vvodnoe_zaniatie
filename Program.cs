class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());
        int firstnumber = number / 10;
        int secondnumber = number % 10;
        Console.WriteLine($"Первая цифра: {firstnumber}");
        Console.WriteLine($"Вторая цифра: {secondnumber}");
    }
}