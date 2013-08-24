// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
// if there’s no such element. Use the method from the previous exercise.

using System;

class FirstElementBiggerThanNeighbors
{
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
        // for tests
        //int[] array = { 1, 3, 5, 7, 9, 8, 6, 4, 2 };
        int index = -1;
        for (int i = 1; i < array.Length-1; i++)
        {
            // using a method from exercise 5th
            if (IsElementBiggerThanNeighbors.IsElementBigger(array, i) == true)
            {
                index = i;
                break;
            }
        }
        Console.WriteLine("The element with index {0} is bigger than its two neighbors", index);
    }
}
