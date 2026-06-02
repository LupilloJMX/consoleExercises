using System;
using System.Net.Mail;

public class basicCalculetor
{
    private static void Main(string[] args) 
    {
        Console.WriteLine("Enter the first number: ");
        int fn = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int sn = int.Parse(Console.ReadLine());

       int sum = fn + sn;
       int subtraction = fn - sn;
       int multiplication = fn * sn;
        int division = fn / sn;
        int remainder = fn % sn;
        

        Console.WriteLine($"{fn} + {sn} = {sum}");
        Console.WriteLine($"{fn} - {sn} = {subtraction}");
        Console.WriteLine($"{fn} x {sn} = {multiplication}");
        Console.WriteLine($"{fn} / {sn} = {division}");
        Console.WriteLine($"{fn} mod {sn} = {remainder}");

        /* 
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);

        */


    }
}