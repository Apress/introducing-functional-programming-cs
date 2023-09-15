using static System.Console;
WriteLine("Exercise 7.6");
int result = Enumerable
   .Range(1, 5)
   .Where(x => x % 2 == 1)
   //.Aggregate(5, (x, y) => x * y);
    .Aggregate(5, (x, y) =>
    {
        // Testing the intermediate values
        WriteLine($"Current:{x}, Next:{y}, Temp: {x * y}");
        return x * y;
    }
    );
WriteLine($"The result is:{result}");
