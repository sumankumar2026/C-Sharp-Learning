using System;
public class Count
{
    public static void Run()
    {
        Console.Write("Enter String : ");
        string str = Console.ReadLine();
        int digit = 0, alpha = 0, spchar = 0;
        foreach (char ch in str)
        {
            if(char.IsLetter(ch))
                alpha++;
            else if (char.IsDigit(ch))
                digit++;
            else spchar++;
        }
        Console.WriteLine($"alphabat is {alpha}");
        Console.WriteLine($"Digit is {digit}");
        Console.WriteLine($"spchar is {spchar}");
    }
}