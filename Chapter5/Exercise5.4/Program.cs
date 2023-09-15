using CustomLibrary;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

var add10 = new Sample().AddNumbers(10);
var add20 = add10(20);
WriteLine($"10+20 is:{add20}");

// using extension method
var uncurried = new Sample().AddNumbers.UnCurry();
var result = uncurried(25, 35);
WriteLine($"25+35 is:{result}");

class Sample
{
    public Func<int, Func<int, int>> AddNumbers = x => y => x + y;

}

namespace CustomLibrary
{
    public static class CurryExtensions
    {
        //public static Func<int, int, int> UnCurry(this Func<int, Func<int, int>> f)
        //{
        //    return (int x, int y) => f(x)(y);            
        //}
        // Generic version
        public static Func<T1,T2,TResult> UnCurry<T1,T2,TResult>(this Func<T1, Func<T2, TResult>> f)
        {            
            return (T1 arg1, T2 arg2) => f(arg1)(arg2);
        }
    }
}
