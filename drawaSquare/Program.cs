using System;


public class drawaSquare 
{
    private static void Main(string[] args)
    {
        int x =Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());

        for(int row = 0; row< width; row++) 
        {
            for(int col = 0; col< width; col++) 
            {
                Console.Write(x);

            }

            Console.WriteLine();
            //
        }

    }

}