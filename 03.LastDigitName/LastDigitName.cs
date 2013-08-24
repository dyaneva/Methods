// Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 
// 1024  "four", 12309  "nine".

using System;

class LastDigitName
{
    static string DigitName(int digit)
    {
        string nameOfDigit;
        switch (digit)
        {
            case 0:
                nameOfDigit = "Zero";
                break;
            case 1:
                nameOfDigit = "One"; 
                break;
            case 2:
                nameOfDigit = "Two";
                break;
            case 3:
                nameOfDigit = "Three";
                break;
            case 4:
                nameOfDigit = "Four";
                break;
            case 5:
                nameOfDigit = "Five";
                break;
            case 6:
                nameOfDigit = "Six";
                break;
            case 7:
                nameOfDigit = "Seven";
                break;
            case 8:
                nameOfDigit = "Eight";
                break;
            case 9:
                nameOfDigit = "Nine";
                break;
            default:
                Console.WriteLine("Invalid digit!");
                return null;
        }
        return nameOfDigit;
    }
    static int GetLastDigit(int number)
    {
        return number % 10;        
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit is: {0}", DigitName(GetLastDigit(number)));
    }
}
