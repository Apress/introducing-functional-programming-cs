using LanguageExt;
using static System.Console;

WriteLine("***Demonstration 2: exception handling in FP.***");

int dividend = new Random().Next(10, 12);
int divisor = new Random().Next(3);
WriteLine($"Dividend: {dividend}, Divisor: {divisor}");
var result = Calculator.GetQuotient(dividend, divisor);

//// If you want to process the valid scenario only
//result.IfRight(x => WriteLine($"(Using IfRight),Quotient: {result.Case}"));
//// OR
//if (result.IsRight) { WriteLine($"(Using IsRight),Quotient: {result.Case}"); }

// If we want to handle both scenarios
result.Match(
    Right: success => WriteLine($"Quotient={success}"),
    Left: error => WriteLine($"Error: {error}")
    );

//namespace FunctionalCsharp
//{
class Calculator
{
    public static Either<Exception, int> GetQuotient(int a, int b)
    {
        return b == 0
         ? new DivideByZeroException("Divisor becomes Zero.")
         : (a / b);
    }
}
//}
