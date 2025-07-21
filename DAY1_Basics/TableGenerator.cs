using System;

public class TableGenerator
{
    public static void Run()
    {
        Console.Write("Enter Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} X  {i}  = {number * i}");
        }
    }
}