using System;

public class Exercises
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Calculate the surface area and volume of a sphere, given its radius");
        Console.WriteLine("Enter the raduis");
        float raduis = float.Parse(Console.ReadLine());

        float superfaceArea = 4 * (float)Math.PI * (float)Math.Pow(raduis, 2);
        float volume = 4 / 3 * (float)Math.PI * (float)Math.Pow(raduis, 3);

        Console.WriteLine($"Superface : {superfaceArea}");
        Console.WriteLine($"Volume : {volume}");

    }

}


