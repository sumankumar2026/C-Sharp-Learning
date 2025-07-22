using System;
public class Program
{
    public static void Main(string[] args)
    {
        // int number1 = 45;
        // int number2 = number1;
        // Console.WriteLine("here number2 is : " + number2);
        // number2 = 36;
        // Console.WriteLine("number1 is : " + number1);
        // Console.WriteLine("number2 is: " + number2);

        // int number1 = 45;
        // ref int number2 = ref number1;
        // number2 = 05;
        // Console.WriteLine("number1 is: " + number1); // 05
        // Console.WriteLine("number2 is: " + number2); // 05

        int number = 10;
        // MyFunction.Run(ref number);

        InKeyWord.Run(in number);
        Console.WriteLine(number);
    }

}