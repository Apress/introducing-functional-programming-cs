using CustomLibrary;
using static System.Console;
WriteLine("Applying the concept of currying and partial application.");
int a = 10, b = 20, c = 30;
// Case-1: Adding the arguments one-by-one
var after1stNumber = new Sample().AddThreeNumbers.Curry()(a);
var after2ndNumber = after1stNumber(b);
var after3rdNumber = after2ndNumber(c);
WriteLine($"a+b+c is {after3rdNumber}");

// Case-2: Passing one argument,and then
// two arguments( separated by commas)
var afterA = new Sample().AddThreeNumbers.UsePartial()(a);
var afterBandC = afterA(b, c);
WriteLine($"a+b+c is {afterBandC}");

// Case-3: Passing two arguments,and then
// one argument( separated by commas)
var afterAandB = new Sample().AddThreeNumbers.UsePartial2()(a, b);
var afterC = afterAandB(c);
WriteLine($"a+b+c is {afterC}");

class Sample
{
   public Func<int, int, int, int> AddThreeNumbers = (int x, int y, int z) => x + y + z;
}

namespace CustomLibrary
{
    public static class CurryExtensions
    {
        public static Func<int, Func<int, Func<int, int>>> Curry(this Func<int, int, int, int> f)
        {
            return x => y => z => f(x, y, z);
        }
        public static Func<int, Func<int, int, int>> UsePartial(this Func<int, int, int, int> f)
        {
            return x => (y, z) => x + y + z;
        }
        public static Func<int, int, Func<int, int>> UsePartial2(this Func<int, int, int, int> f)
        {
            return (x, y) => z => x + y + z;
        }
    }
}

