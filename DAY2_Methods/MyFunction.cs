public class MyFunction
{
    public static void Run(ref int x)
    {
        x = x + 10;
        Console.WriteLine("X is : " + x);
    }
}