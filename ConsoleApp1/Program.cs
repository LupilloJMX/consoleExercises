using System;

public class multiplicationofThreeFactors
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int fn = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int sn = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number");
        int tn = int.Parse(Console.ReadLine());
        int multiplication = fn * sn * tn;
        Console.WriteLine($"{fn} x {sn} x {tn} = {multiplication}");
    }
}