using System;

public class CelsiusToKelvinAndFahrenheit 
{
    private static void Main(string[] arg) 
    {
        int Celsius = int.Parse(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", Celsius + 273);
        Console.WriteLine("Fahrenheit = {0}",Celsius * 18 / 10 + 32 );
    }
}