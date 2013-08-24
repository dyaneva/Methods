// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] 
// contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 
// 10 000 digits.

using System;
using System.Text;

class NumbersAsArraysOfDigits
{
    // presenting given number as array of digits
    static int[] RepresentNumberAsArray(int number)
    {
        int lenght = number.ToString().Length;
        int[] array = new int[lenght];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number % 10;
            number /= 10;
        }
        return array;
    }
    // adding two arrays of digits
    static string AddTwoNumbers(int[] first, int[] second) // first number > second number
    {
        if (first.Length < second.Length)
        {
            return AddTwoNumbers(second, first);
        }
        string result = "";
        int carry = 0;
        int sum = 0;
        for (int i = 0; i < second.Length; i++)
        {
            sum = first[i] + second[i] + carry;
            if (sum >= 10)
            {
                carry = 1;
                sum = sum % 10;
                result += sum.ToString();
            }
            else
            {
                result += sum.ToString();
                carry = 0;
            }            
        }
        for (int i = second.Length; i < first.Length; i++)
        {
            sum = first[i] + carry;
            if (sum >= 10)
            {
                carry = 1;
                sum = sum % 10;
                result += sum.ToString();
            }
            else
            {
                result += sum.ToString();
                carry = 0;
            }
            if (carry == 1)
            {
                result += 1;
            }
        }
        return result;
    }
    // printing the result
    static void PrintArray(string array)
    {
        for (int i = array.Length-1; i >=0; i--)
        {
            Console.Write(array[i]);            
        }
        Console.WriteLine();
    }
    // check input data
    static int CheckNumber()
    {
        int number;
        while (int.TryParse(Console.ReadLine(), out number) && number < 0)
        {
            Console.Write("Invalid input! Enter positive number! Please enter again: ");
        }
        return number;
    }
    static void Main()
    {       
        Console.Write("Enter first positive number: ");
        int firstNumber = CheckNumber();
        Console.Write("Enter second positive number: ");
        int secondNumber = CheckNumber();
        int[] firstArray = RepresentNumberAsArray(firstNumber);
        int[] secondArray = RepresentNumberAsArray(secondNumber);
        PrintArray(AddTwoNumbers(firstArray, secondArray));       
    }
}
