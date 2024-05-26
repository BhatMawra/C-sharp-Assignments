// Text manipulation

using System;

class Program
{
    static void Main()
    {
        // Step 1: Get the input string from the user
        Console.Write("Please enter a string: ");
        string inputString = Console.ReadLine();

        // Step 2: Remove leading and trailing whitespace
        string trimmedString = inputString.Trim();
        Console.WriteLine($"Trimmed String: '{trimmedString}'");

        // Step 3: Ask user for their choice to convert to uppercase or lowercase
        Console.Write("Do you want to convert the string to (U)ppercase or (L)owercase? Enter U or L: ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        string modifiedString;
        if (choice == 'U')
        {
            modifiedString = trimmedString.ToUpper();
        }
        else if (choice == 'L')
        {
            modifiedString = trimmedString.ToLower();
        }
        else
        {
            Console.WriteLine("Invalid choice. The string will remain unchanged.");
            modifiedString = trimmedString;
        }

        Console.WriteLine($"Modified String: '{modifiedString}'");

        // Step 4: Ask for start and end indices for substring extraction
        Console.Write("Enter the start index for substring extraction: ");
        int startIndex = int.Parse(Console.ReadLine());

        Console.Write("Enter the end index for substring extraction: ");
        int endIndex = int.Parse(Console.ReadLine());

        // Ensure indices are within valid range
        if (startIndex >= 0 && endIndex < modifiedString.Length && startIndex <= endIndex)
        {
            string substring = modifiedString.Substring(startIndex, endIndex - startIndex + 1);
            Console.WriteLine($"Extracted Substring: '{substring}'");
        }
        else
        {
            Console.WriteLine("Invalid indices. Unable to extract substring.");
        }
    }
}
