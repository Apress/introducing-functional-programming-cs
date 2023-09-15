using CustomLibrary;
using static System.Console;

WriteLine("Understanding deferred execution.");
var input = Enumerable.Range(1, 5);
var output1 = input.Map3(x => x * x);
var output2 = input.Map2(x => x * x);

// output1 is not computed yet
// but output 2 is computed already.
foreach (int i in output1)
{
    WriteLine(i);
}
foreach (int j in output2)
{
    WriteLine(j);
}
namespace CustomLibrary
{
    public static class Extensions
    {
        public static IEnumerable<TResult> Map2<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, TResult> f) // OK
        {
            List<TResult> output = new();
            foreach (var item in container)
            {
                output.Add(f(item));
            }             
            return output;
        }
        // using yield return
        public static IEnumerable<TResult> Map3<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, TResult> f) // OK
        {
            foreach (var item in container)
                yield return f(item);
        }

        public static List<TResult> Map<TSource, TResult>(this List<TSource> container, Func<TSource, TResult> f)
        {
            List<TResult> output = new();
            foreach (var item in container)
            {
                output.Add(f(item));
            }
            //container.ForEach(item => output.Add(f(item)));
            return output;
        }
    }
}



