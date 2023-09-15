using LanguageExt;
using static System.Console;

// WriteLine("Handling multiple exceptions and computing (a/b)+c.");
int a = new Random().Next(10, 15);
int b = new Random().Next(3);
string? input = IO.GetUserInput();

WriteLine($"a={a},b={b},c={input}");
WriteLine($"Trying to compute:(a / b) + c");
//IO.Display($"Trying to compute:(a / b) + c");


// Functional style
Calculator
  .Calculate(a, b, input)
  .Match(
     Right: x => WriteLine($"Result={x}"),
     Left: e => WriteLine($"{e.Message}")
     );

//Calculator
//  .Calculate2(a, b, input)
//  .Match(
//     Right: x => WriteLine($"Result={x}"),
//     Left: WriteLine
//     );

static class Calculator
{
    /// <summary>
    /// It computes (a/b)+c and handles multiple exceptions
    /// </summary>
    public static Either<Exception, int> Calculate(int a, int b, string? input)
    {
        bool flag = int.TryParse(input, out int c);
        return !flag
             ? new FormatException("Invalid input: try an integer.")
             : b == 0
                ? new DivideByZeroException("Divisor becomes Zero.")
                : (a / b) + c;
    }

    //public static Either<string, int> Calculate2(int a, int b, string? input)
    //{
    //    bool flag = int.TryParse(input, out int c);
    //    return !flag
    //         ? $"Invalid input: try an integer."
    //         : b == 0
    //            ? $"Divisor becomes Zero."
    //            : (a / b) + c;
    //}
}
static class IO
{
    public static string? GetUserInput()
    {
        WriteLine("Enter an integer:");
        string? input = ReadLine();
        return input;
    }
    //public static void Display(object? msg)
    //{
    //    WriteLine(msg);
    //}
}

