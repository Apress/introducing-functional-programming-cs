using static System.Console;
WriteLine("Understanding the fold pattern.");
var integers = Enumerable.Range(1, 10).ToArray();
WriteLine("The original set of numbers is:");
integers
    .ToList()
    .ForEach(x => Write(x + " "));

WriteLine("\nThe highest number is:");
int highest = integers.Max();
WriteLine(highest);

WriteLine("\nFinding the total of original numbers:");
int total = integers.Sum();
WriteLine(total);


WriteLine("\nMultiplying each element by -5 and now the highest number is:");
highest = integers.Max(x => x * (-5));
WriteLine(highest);

WriteLine("\nFinding the total of those numbers that are divisible by 3:");
//int total2 = integers.Where(x => x % 3 == 0).Sum();
//WriteLine(total2);
total = integers.Where(x => x % 3 == 0).Sum();
WriteLine(total);


WriteLine("\nFinding the factorial of 6.");
int factorial = Enumerable
   .Range(1, 6)
 //.Aggregate((x, y) =>
 //{
 //    // Showing the intermediate values
 //    WriteLine($"Current:{x}, Next:{y}, Temp: {x*y}"); 
 //    return x * y;
 //}
 //);
 .Aggregate((x, y) => x * y); // Works too
WriteLine($"The factorial of 6 is:{factorial}");




