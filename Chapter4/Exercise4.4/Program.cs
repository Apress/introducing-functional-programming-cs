using FpLibrary;
using static System.Console;

WriteLine("Exercise 4.4");
/*
Func<int, int, int> makeTotal = (x, y) => x + y;
Func<int, int> makeCube = x => x * x * x;
int tempResult = makeTotal(2, 3);
int finalResult = makeCube(tempResult);
WriteLine($"Result: {finalResult}");

// Using HOF
var combinedFunc = makeTotal.Compose(makeCube);
int result = combinedFunc(2, 3);
WriteLine($"Result: {result}");
*/
// Using pipeline pattern

var result = 2.MakeTotal(3)
              .MakeCube();
WriteLine($"Result: {result}");

namespace FpLibrary
{
    public static class Extensions
    {
        //public static Func<int, int, int> Compose(
        //    this Func<int, int, int> total,
        //    Func<int, int> cube)
        //{
        //    return (x, y) => cube(total(x, y));
        //}

        public static int MakeTotal(this int a, int b) => a + b;
        public static int MakeCube(this int a) => a * a * a;

    }
}
