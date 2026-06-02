using System;

public class equivalentOperations
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
       int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((x+y)*z);
        Console.WriteLine(x*z+y*z);

    }
}