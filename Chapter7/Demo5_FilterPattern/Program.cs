using CustomLibrary;
using static System.Console;
var integers = Enumerable.Range(1, 5).ToList();
WriteLine("The original set of integers is:");
integers.ForEach(x => Write(x + "\t"));
WriteLine("\nThe even numbers are:");
integers
    .Filter(x => x % 2 == 0)
    .ToList()
    .ForEach(WriteLine);

double[] realNumbers = { 20.25, 30.37, 40.42, 50.57, 60.75 };
WriteLine("\nThe original set of real numbers is:");
realNumbers.ToList().ForEach(x => Write(x + "\t"));
WriteLine("\nThe real numbers that are greater than 50.2 are:");
realNumbers
    .Filter(x => x > 50.2)
    .ToList()
    .ForEach(WriteLine);

List<string> names = new() { "Sam", "Bob", "Jack", "Kate", "Joseph" };
WriteLine("\nThe original set of names:");
names.ForEach(x => Write(x + "\t"));

WriteLine("\nThe names that start with ‘S’, or contain more than 3 characters are:");
names
    .Filter(x => x.Length > 3 | x.StartsWith('S'))
    .ToList()
    .ForEach(WriteLine);

namespace CustomLibrary
{
    public static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> container, Func<T, bool> f)
        {
            foreach (var item in container)
            {
                if (f(item))
                {
                    yield return item;
                }
            }
        }
    }
}



