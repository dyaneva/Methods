// Write a program that can solve these tasks: 1. Reverses the digits of a number; 2. Calculates the average of 
// a sequence of integers; 3. Solves a linear equation a * x + b = 0
// Create appropriate methods. Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data: 1. The decimal number should be non-negative; 2. The sequence should not be empty; 
// 3. a should not be equal to 0

using System;

class Tasks
{
    // reversing the digits of number
    static string ReverseDigitsOfNumber(decimal number)
    {
        string num = number.ToString();
        string result = "";
        for (int i = num.Length - 1; i >= 0; i--)
        {
            result += num[i];
        }
        return result;
    }
    // calculating the average of numbers
    static double AverageOfIntegers(int[] array)
    {
        int sum = 0;
        int len = array.Length;
        double result = 0;
       
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        result = (double)sum / (double)len;        
        return result;
    }
    // solving a linear equation a * x + b = 0
    static decimal LinearEquation(decimal a, decimal b)
    {
        decimal x = -b / a;
        return x;
    }
    // simple text-based menu for the user to choose which task to solve.
    static void Choice(int number)
    {
        switch (number)
        {
            case 1:
                Console.Write("Enter number: ");
                decimal num;
                while (decimal.TryParse(Console.ReadLine(), out num) && num < 0)
                {
                    Console.Write("Invalid input! Enter non-negative number! Please try again: ");
                }
                Console.WriteLine(ReverseDigitsOfNumber(num));
                break;
            case 2:
                Console.Write("Enter lenght of integer sequence: ");
                int n;
                while (int.TryParse(Console.ReadLine(), out n) && n <= 0)
                {
                    Console.Write("Invalid input! Please enter again: ");
                }
                Console.WriteLine("Enter the elements of sequence:");
                int[] array =new int[n];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Element {0} = ", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(AverageOfIntegers(array));
                break;
            case 3:
                Console.WriteLine("Enter two numbers of linear equation a * x + b = 0");
                Console.Write("Enter number a = ");
                decimal a;
                while (decimal.TryParse(Console.ReadLine(), out a) && a == 0)
                {
                    Console.Write("Invalid input! Number a should be different from zero! Please try again: ");
                }
                Console.Write("Enter number b = ");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.WriteLine(LinearEquation(a, b));
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
    static void Main()
    {
        Console.WriteLine("1. Reverses the digits of a number.");
        Console.WriteLine("2. Calculates the average of a sequence of integers.");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0.");
        Console.Write("Enter your choice (1 or 2 or 3): ");
        int number = int.Parse(Console.ReadLine());        
        Choice(number);
    }
}
