// Text analyzer

using System;

class Program
{
    static void Main()
    {
        // Step 1: Get the input string from the user
        Console.Write("Please enter a paragraph or text: ");
        string inputText = Console.ReadLine();

        // Step 2: Split the text into words
        string[] words = inputText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Step 3: Count the total number of words
        int totalWords = words.Length;

        // Step 4: Calculate the total number of letters in all words
        int totalLetters = words.Sum(word => word.Length);

        // Step 5: Calculate the average word length
        double averageWordLength = (double)totalLetters / totalWords;

        // Step 6: Display the statistics
        Console.WriteLine($"Total number of words: {totalWords}");
        Console.WriteLine($"Average word length: {averageWordLength:F2}");
    }
}

