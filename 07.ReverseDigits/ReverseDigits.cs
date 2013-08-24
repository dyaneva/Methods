// Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseDigits
{
    static string ReverseDigitsOfNumber(decimal number)
    {
        string num = number.ToString();
        string result = "";
        for (int i = num.Length-1; i >= 0; i--)
        {
            result += num[i];
        }
        if (number < 0)
        {
            return "-" + result.TrimEnd('-');
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReverseDigitsOfNumber(number));
    }
}