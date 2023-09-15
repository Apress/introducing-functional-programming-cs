using ExtLibrary;
using static System.Console;

WriteLine("Experimenting pipelining.");
int a=10, b=20, c=25;

var result = Sample.Sum(a, b).IsGreater(c);
WriteLine($"Is {a}+{b} greater than {c}? {result}");

// Testing new values
a = 25;
b = 45;
c = 100;

result = Sample.Sum(a, b).
                IsGreater(c);
WriteLine($"Is {a}+{b} greater than {c}? {result}");


static class Sample
{
   public static int Sum(int x, int y) => x + y;
    
}
namespace ExtLibrary
{
    public static class Extensions
    {
        public static bool IsGreater(this int x, int y) => x > y;
       
    }
}