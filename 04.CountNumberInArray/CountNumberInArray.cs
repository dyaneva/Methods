// Write a method that counts how many times given number appears in given array. Write a test program to check 
// if the method is working correctly.

// To run the test go to the menu TEST -> Run and choose which test you want to run.

using System;

public class CountNumberInArray
{
    public static int CountGivenNumberInArray(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==number)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array =new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number {0} appears {1} times", number, CountGivenNumberInArray(array, number));
    }
}
