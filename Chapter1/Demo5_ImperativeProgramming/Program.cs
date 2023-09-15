using static System.Console;

WriteLine("Using an imperative style of coding.");
List<int> numbers = new() { 10, 20, 30, 40, 50 };
// Imperative style
WriteLine("The list includes the following:");
foreach (int number in numbers)
{
    Write(number + "\t");
}
WriteLine("\nAges that are more than 30:");
foreach (int number in numbers)
{
    if (number > 30)
    {
        Write(number + "\t");
    }
}

