using System;
public class Calculator
{
    public static void Run()
    {
        Console.WriteLine("Assignment start from here...");
        Console.Write("Enter Number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Number2: ");
        int Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Symbol +,-,*, : ");
        char sym = Console.ReadLine()[0];

        int Adding = number1 + Number2;
        int substracting = number1 - Number2;
        int multipliaction = number1 * Number2;

        switch (sym)
        {
            case '+':
                Console.WriteLine(Adding);
                break;
            case '-':
                Console.WriteLine(substracting);
                break;
            case '*':
                Console.WriteLine(multipliaction);
                break;
            case '/':
                if (Number2 != 0)
                {
                    int result = (number1 / Number2);
                    Console.WriteLine("Result is: " + result);
                }
                else
                {
                    Console.WriteLine("can not be divide by 0");
                }
                break;
        }
    }
}