using System;

public class generateaRandomNumber 
{
   private static void Main(string[] args) 
   {
        int a =Convert.ToInt32(Console.ReadLine());
        int b =Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        int randomNumber = random.Next(a, b +1 );

        Console.WriteLine("Random number between {0} and {1}: {2}", a, b, randomNumber);



    }
}