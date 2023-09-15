using LanguageExt;
using static System.Console;

int dividend = new Random().Next(10, 12);
int divisor = new Random().Next(3);
WriteLine($"Dividend: {dividend}, Divisor: {divisor}");
var value4 = GetQuotient(dividend, divisor)
    .Match
    (
     Some: x => WriteLine($"{dividend}/{divisor}= {x}"),
     None: () => WriteLine("Error: Divisor becomes Zero.")
    );

static Option<int> GetQuotient(int a, int b)
{
    return b != 0
         // ? Option<int>.Some(a / b)
         ? a / b
         : Option<int>.None;
}


