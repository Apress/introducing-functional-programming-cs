using static System.Console;
using CustomLibrary;
WriteLine("Exercise 7.3");
var input = Enumerable.Range(10, 5);
WriteLine("Increasing each element by 5:");
input.Map(x => x + 5)
     .ToList()
     .ForEach(WriteLine);
namespace CustomLibrary
{
    public static class Extensions
    {
        public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, TResult> f)
        {
            return container.Select(f);
        }
    }
}
