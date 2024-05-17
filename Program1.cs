// Assignment 2: Write a C# program to swap two numbers
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before swap:");
        Console.WriteLine($"a = {a}, b = {b}");

        // Swap logic
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swap:");
        Console.WriteLine($"a = {a}, b = {b}");
    }
}


