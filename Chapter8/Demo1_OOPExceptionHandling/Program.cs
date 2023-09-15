using static System.Console;

WriteLine("***Case study on exception handling in OOP.***");
int dividend = new Random().Next(10, 12);
int divisor = new Random().Next(3);
WriteLine($"Dividend: {dividend}, Divisor: {divisor}");
int quotient = 0;

try
{
    quotient = Calculator.GetQuotient(dividend, divisor);
}
catch (Exception e)
{
    WriteLine($"Error:{e}");
}

WriteLine($"Quotient: {quotient}");

class Calculator
{
    public static int GetQuotient(int a, int b) => a / b;

}

