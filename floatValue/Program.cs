using System;

public class floatValue 
{
    private static void Main(string[] args)
    {
        float distance = Convert.ToSingle(Console.ReadLine());
        float hour = Convert.ToSingle(Console.ReadLine());
        float min = Convert.ToSingle(Console.ReadLine());
        float sec = Convert.ToSingle(Console.ReadLine());

        float timeBySeconds = hour * 3600 + min * 60 + sec;
        float mps = distance / timeBySeconds;
        float kph = (distance / 1000.0f) / (timeBySeconds / 3600.0f);
        float mph = kph / 1.609f;

        Console.WriteLine("Speed in meters/sec is {0}", mps);
        Console.WriteLine("Speed in km/h is {0}", kph);
        Console.WriteLine("Speed in mile/h is {0}",mph);

    }
}