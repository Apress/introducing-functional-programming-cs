using CustomLibrary;
using static System.Console;
WriteLine("Exercise 5.5");
int a = 10, b = 20, c = 30;

var afterA = new Sample().Calculate.UsePartial()(a);
var afterBandC = afterA(b, c);
WriteLine($"{b} * {c} + {a} is {afterBandC}");


class Sample
{
    public Func<int, int, int, int> Calculate = (int x, int y, int z) => y * z + x;
}

namespace CustomLibrary
{
    public static class Extensions
    {
        public static Func<int, Func<int, int, int>> UsePartial(this Func<int, int, int, int> f)
        {
            return x => (y, z) => f(x, y, z);
        }

    }
}


