using LanguageExt;
using static System.Console;
using static Calculator;
using static IO;

var input = GetUserInput();
Validate(input);

static class Calculator
{
    /// <summary>
    /// It parses the user's input
    /// </summary>
    public static Either<Exception, int> ParseInput(string input)
    {
        bool flag = int.TryParse(input, out int number);
        return !flag
             ? new FormatException("Invalid input: Try an integer.")
             : number;
    }

    /// <summary>
    /// It checks whether the integer is positive
    /// </summary>
    public static Either<Exception, int> CheckNonNegativity(int input)
    {
        return input < 0
             ? new Exception("Invalid input: Try an non-negative integer.")
             : input;
    }

}
static class IO
{
    public static string? GetUserInput()
    {
        WriteLine("Enter a non-negative integer:");
        string? input = ReadLine();
        return input;
    }
    public static void Validate(string input)
    {
        // Using in-built Bind function from LanguageExt
        ParseInput(input)
         .Bind(CheckNonNegativity)
         .Match(
          Right: x => WriteLine($"Great. Entered a valid number: {x}"),
          Left: (e) => WriteLine($"Error: {e.Message}")
         );
    }
}

