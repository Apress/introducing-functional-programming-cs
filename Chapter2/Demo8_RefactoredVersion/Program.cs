using static System.Console;
var result = Transformer.MultiplyBy(5.5, 2);
WriteLine($"Result: {result}");

static class Transformer
{
    public static double MultiplyBy(
     double input, double multiplier)
    {
        return input * multiplier;
    }
}

