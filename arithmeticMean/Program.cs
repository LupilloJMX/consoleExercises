using System;

public class arithmeticMean
{
    private static void Main(string[] args)
    {
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());
        int n4 = Convert.ToInt32(Console.ReadLine());
         
        int result = (n1 + n2 + n3 + n4) / 4;

        Console.WriteLine(result);

    }
}