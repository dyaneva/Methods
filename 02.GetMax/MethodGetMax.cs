// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 
// 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class MethodGetMax
{
    static int GetMax(int first, int second)
    {
        int result = Math.Max(first, second);
        return result;
    }
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is: {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
    }
}