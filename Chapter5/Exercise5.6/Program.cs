using CustomLibrary;
using static System.Console;
WriteLine("Exercise 5.6");


var afterTwoInputs = new Sample().Display.UsePartial()("red", "green");
var afterLastInput = afterTwoInputs("yellow");
WriteLine($"{afterLastInput}");
class Sample
{    
    public Func<string, string, string, string> Display = (string x, string y, string z) => $"{x},{y},{z}";
}

namespace CustomLibrary
{
    public static class Extensions
    {
        public static Func<string, string, Func<string, string>> UsePartial(this Func<string, string, string, string> f)
        {
            return (x, y) => z => $"Mixing {z} with {y} and {x}.";
        }
    }
}



