using System;

public class calculateValuesofaFunction
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        int z;

        for (int i=x; i<=y; i++) 
        {
            z = i * i - 2 * i + 1;
            Console.Write("{0}",z);

        }



    }
}