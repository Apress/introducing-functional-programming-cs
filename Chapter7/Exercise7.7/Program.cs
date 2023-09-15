using static System.Console;
WriteLine("Exercise 7.7");
var result = Enumerable.Range(1, 5)
                       .Select(x => Math.Pow(x, 3))
                       .Sum();
WriteLine($"The result is: {result}");
