namespace Excercise3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running, Program!");

        Rectangle rec = new Rectangle(4.5F, 3.2F);

        Console.WriteLine($"The area of rectangle is {rec.CalculateArea()}.");

        Console.ReadKey();
    }
}

