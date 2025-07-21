// ConditionalStatements.cs
public class ConditionalStatements
{
    public static void Run(int number)
    {
        Console.WriteLine("=== Conditional Example ===");
        if (number % 2 == 0)
            Console.WriteLine("Even number");
        else
            Console.WriteLine("Odd number");
    }
}
