using ExtLibrary;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

WriteLine("Composing functions using HOF.");
Func<int,int, int> sum = (x, y) => x + y;
Func<int, int, bool> isGreater = (x, y) => x > y;

//var composedFunc = sum.Compose(isGreater);
//var composedFunc = sum.Compose((x, y) => x > y);
var composedFunc = sum.GenericCompose(isGreater);
int a = 10, b = 20, c = 25;
bool result = composedFunc(a,b,c);
WriteLine($"Is {a}+{b} greater than {c}? {result}");

// Testing new values
a = 25;
b = 45;
c = 100;
result = composedFunc(a, b, c);
WriteLine($"Is {a}+{b} greater than {c}? {result}");


namespace ExtLibrary
{
    public static class Extensions
    {
        public static Func<int, int, int, bool> Compose(this Func<int, int, int> func1, Func<int, int, bool> func2)
        {
            return (x, y, z) => func2(func1(x, y), z);
        }
       
        // Generic version
        public static Func<T,T,T,bool> GenericCompose<T>(this Func<T,T,T> func1, Func<T, T,bool> func2) where T : struct 
        {
            return (x, y, z) => func2(func1(x, y), z);
        }        
    }
}