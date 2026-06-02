using System;

public class doubleValue 
{
    private static void Main(string[] args)
    
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height; // 2a + 2b = 2(a + b)
        double area = width * height;
        double diagonal = Math.Sqrt(width * width + height * height); // a^2 + b^2 = c^2

        Console.WriteLine("Perimeter: {0}",perimeter);
        Console.WriteLine("Area: {0}", area);
        Console.WriteLine("Diagonal: {0}", diagonal);

        ;
    }
}