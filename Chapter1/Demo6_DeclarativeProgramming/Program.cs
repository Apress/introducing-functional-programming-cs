using static System.Console;
WriteLine("Using the declarative style of coding.");
List<int> numbers = new() { 10, 20, 30, 40, 50 };
WriteLine("The list includes the following:");
numbers.ForEach(x => Write(x + "\t"));
WriteLine("\nAges that are more than 30:");
numbers.Where(x => x > 30)
    .Select(x => x)
    .ToList()
    //.ForEach(Write);
    .ForEach(x => Write(x + "\t"));

// Varying function calls
WriteLine("\nAges that are more than 30:");
numbers.Select(x => x)
    .Where(x => x > 30)
    .ToList()
    .ForEach(x => Write(x + "\t"));
