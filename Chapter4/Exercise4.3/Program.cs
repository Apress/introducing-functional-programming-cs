using FpLibrary;
using static System.Console;

WriteLine("Exercise 4.3");
Func<int, int, int> makeTotal = (x, y) => x + y;
Func<int, int> makeCube = x => x * x * x;
//int tempResult = makeTotal(2, 3);
//int finalResult= makeCube(tempResult);
//WriteLine($"Result: {finalResult}");

// Using HOF
var combinedFunc = makeTotal.Compose(makeCube);
//var combinedFunc = makeTotal.GenericCompose(makeCube);
var result = combinedFunc(2, 3);
WriteLine($"Result: {result}");

namespace FpLibrary
{
    public static class Extensions
    {
        public static Func<int, int, int> Compose(
            this Func<int, int, int> total,
            Func<int, int> cube)
        {
            return (x, y) => cube(total(x, y));
        }
        // Generic Version
        //public static Func<T,T,T> GenericCompose<T>(
        //  this Func<T,T,T> total,
        //  Func<T,T> cube)
        //{
        //    return (x, y) => cube(total(x,y));
        //}

        // OR

        public static Func<T, T, T> GenericCompose<T>(
          this Func<T, T, T> total,Func<T, T> cube) =>
            (x, y) => cube(total(x, y));       
    }
}
