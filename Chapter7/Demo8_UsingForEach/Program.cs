using static System.Console;
using Extensions;
WriteLine("Understanding the fold pattern.");
var integers = Enumerable.Range(1, 10).ToArray();
//var integers = Enumerable.Range(1, 10).ToList();
WriteLine("The original set of numbers are:");
integers
    .ToList()
    .ForEach(x => Write(x + " "));

// Using CustomForEach
WriteLine("\nThe original set of numbers are using custom ForEach:");
integers
    //.ToList()
    .ForEach(x => Write(x + " "));
namespace Extensions
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T>
          sequence, Action<T> action)
        {
            if (action != null)
            {
                foreach (T item in sequence)
                {
                    action(item);
                }
                // Works too
                //sequence.ToList().ForEach(item=>action(item));
            }
        }
    }
}
