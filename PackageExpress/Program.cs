// Welcome the user and ask for the package weight.
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
Console.WriteLine("Please enter the package weight:");
decimal weight = decimal.Parse(Console.ReadLine() ?? "");

// End the program beforeasking for  dimansions if the packege is too heavy.
if (weight > 50)
{
    Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// Read the dimensions in the order required by the assignment.
Console.WriteLine("Please enter the package weight:");
decimal width = decimal.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Please enter the package height:");
decimal height = decimal.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Please enter the package lenght:");
decimal length = decimal.Parse(Console.ReadLine() ?? "");

// Add the demensions to check whether the package is too big to ship.
if (width + height + length > 50)
{
    Console.WriteLine("Package is too big to be shipped via Package Express.");
    return;
}

// Multiply the three dimensions by the weight, then divide by 100.
decimal quote = (width * height * length * weight) / 100;

//Display the quote in dollars with two decimal places.
Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
Console.WriteLine("Thank you!");


