using LanguageExt;
using static System.Console;

// Exercise 8.2
double temp = 250.52;
temp = 25.5;
temp = 0;
MakeDouble(temp)
 .Bind(IncrementByFive)
 .Match
  (
   Right: x => WriteLine($"The transformed value is {x}"),
   Left: e => WriteLine($"Error: {e.Message}")
   );


static Either<Exception, double> MakeDouble(double input)
{
    return input <= 0
        ? new Exception($"the number {input} is not positive.")
        : 2 * input;
}

static Either<Exception, double> IncrementByFive(double input)
{
    return input >= 500
      ? new Exception($"the number {input} should be less than 500")
      : input + 5;
}
