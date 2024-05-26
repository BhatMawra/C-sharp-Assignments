//Extract First Name and Last name

        // Prompt the user for their full name
        Console.Write("Please enter your full name: ");
        string fullName = Console.ReadLine();

        // Trim any leading or trailing whitespace
        fullName = fullName.Trim();

        // Split the full name into parts
        string[] nameParts = fullName.Split(' ');

        // Check if we have enough parts for first and last name
        if (nameParts.Length < 2)
        {
            Console.WriteLine("Please enter at least a first and a last name.");
        }
        else
        {
            // Extract first and last names
            string firstName = nameParts[0];
            string lastName = nameParts[nameParts.Length - 1];

            // Output the results
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
        }
 

