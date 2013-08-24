// Write a method that checks if the element at given position in given array of integers is bigger than 
// its two neighbors (when such exist).

using System;

public class IsElementBiggerThanNeighbors
{
    public static bool IsElementBigger(int[] array, int index)
    {        
        bool isElementBigger = false;
        if (index < array.Length - 1 && index > 0)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isElementBigger = true;                
            }
        }
        else if (index == array.Length-1)
        {
            if (array[index]>array[index-1])
            {
                isElementBigger = true;
            }
        }
        else if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                isElementBigger = true;
            }
        }
        return isElementBigger; 
    }
    static void Main()
    {        
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int index;
        Console.Write("Enter position of element: ");
        while (int.TryParse(Console.ReadLine(), out index)&&(index<0 || index>n-1))
        {
            Console.Write("Invalid input! Please enter again: ");
        }
        Console.WriteLine("The element at position {0} is bigger than its two neigfbors - {1}", index, IsElementBigger(array, index));
    }
}
