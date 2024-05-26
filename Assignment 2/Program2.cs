// Collecting name,email and phone number

using System;

class UserProfile
{
    // Fields to store user profile information
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    // Method to display the user profile information
    public void DisplayProfile()
    {
        Console.WriteLine("User Profile:");
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Create a new instance of UserProfile
        UserProfile userProfile = new UserProfile();

        // Collect user information
        Console.Write("Please enter your full name: ");
        userProfile.FullName = Console.ReadLine();

        Console.Write("Please enter your email: ");
        userProfile.Email = Console.ReadLine();

        Console.Write("Please enter your phone number: ");
        userProfile.PhoneNumber = Console.ReadLine();

        // Display the collected user profile information
        userProfile.DisplayProfile();
    }
}
