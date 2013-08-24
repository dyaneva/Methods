// Write a method that return the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class MaxElementInPortionOfArray
{
    static int FindMaxElement(int[] array, int index)
    {
        int maxIndex = index;
        for (int i=index+1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    static int[] SortAscending(int[] array)
    {
        int[] sortedArray = SortDescending(array);
        sortedArray = sortedArray.Reverse().ToArray();
        return sortedArray;
    }
    static int[] SortDescending(int[] array)
    {        
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = FindMaxElement(array, i);
            int temp = array[maxIndex];
            array[maxIndex] = array[i];
            array[i] = temp;
        }
        return array;
    }    
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        /*Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }*/
        int[] array = { 2,56,15,78,32,18 };
        int index;
        Console.Write("Enter index: ");
        while (int.TryParse(Console.ReadLine(), out index) && (index < 0 || index > array.Length - 1))
        {
            Console.Write("Invalid input! Please enter again: ");
        }
        Console.WriteLine("The maximal element in a portion starting with index {0} is: {1}", index, array[FindMaxElement(array, index)]);
        PrintArray(SortAscending(array));
        PrintArray(SortDescending(array));
    }
}
