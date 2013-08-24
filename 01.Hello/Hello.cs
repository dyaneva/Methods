//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
// Write a program to test this method.

using System;

class Hello
{
    static void Greeting(string name)
    {
        Console.WriteLine("Hello, {0}", name);
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Greeting(name);
    }
}