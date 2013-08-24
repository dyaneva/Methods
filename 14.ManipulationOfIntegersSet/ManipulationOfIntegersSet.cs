// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
// Use variable number of arguments.

using System;

class ManipulationOfIntegersSet
{
    // finding a minimal number
    static int FindMinNumber(params int[] array)
    {
        int minElement = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<minElement)
            {
                minElement = array[i];
            }
        }
        return minElement;
    }
    // finding a maximal number
    static int FindMaxNumber(params int[] array)
    {
        int maxElement = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>maxElement)
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }
    // finding the average of numbers
    static double FindAverageOfNumbers(params int[] array)
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
    // finding the sum of numbers
    static int FindSumOfNumbers(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    // finding the product of numbers
    static int FindProductOfNumbers(params int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
    static void Main()
    {
        // using variable number of arguments
        Console.WriteLine("The minimal number is {0}", FindMinNumber(4, 2, -5, 12, -3, 6, -13));
        Console.WriteLine("The maximal number is {0}",FindMaxNumber(4, 2, -5, 12, -3, 6));
        Console.WriteLine("The average of numbers is {0}", FindAverageOfNumbers(4, 2, -5, 12, -3, 6, -13, 22, -14));
        Console.WriteLine("The sum of numbers is {0}", FindSumOfNumbers(4, 2, -5, 12, -3, 6, -13));
        Console.WriteLine("The product of numbers is {0}", FindProductOfNumbers(4, 2, -5, 12, -3, 6, -13, 5));
    }
}
