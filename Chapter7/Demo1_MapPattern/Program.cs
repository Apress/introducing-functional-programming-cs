using CustomLibrary;
using static System.Console;

//Explicit declaration
List<int> input = Enumerable.Range(1, 5).ToList();
// Implicit declaration using var keyword
// var input = Enumerable.Range(1, 5).ToList();
WriteLine("The original list contains:");
input.ForEach(x => WriteLine(x));

WriteLine("\nUsing Map function:");
#region using Map
WriteLine("Making a square of each element:");
input.Map(x => x * x)
     .ForEach(x => WriteLine(x));

WriteLine("Increasing each number in the list by 3:");
input.Map(x => x + 3)
     .ForEach(x => WriteLine(x));

List<string> names = new() { "Sam", "Jack", "Joseph" };
WriteLine("Names in uppercase:");
names.Map(x => x.ToUpper())
     .ForEach(x => WriteLine(x));
#endregion

WriteLine("\nUsing Map2 function:");

#region using Map2
WriteLine("Making a square of each element:");
input.Map2(x => x * x)
     .ToList()
     .ForEach(x => WriteLine(x));

WriteLine("Increasing each number in the list by 3:");
input.Map2(x => x + 3)
    .ToList()
    .ForEach(x => WriteLine(x));

names = new() { "Sam", "Jack", "Joseph" };
WriteLine("Names in uppercase:");
names.Map2(x => x.ToUpper())
     .ToList()
     .ForEach(x => WriteLine(x.ToUpper()));
#endregion

WriteLine("\nUsing Map3 function:");
#region using Map3
WriteLine("Making a square of each element:");
input.Map3(x => x * x)
      .ToList()
      .ForEach(x => WriteLine(x));

WriteLine("Increasing each number in the list by 3:");
input.Map3(x => x + 3)
    .ToList()
    .ForEach(x => WriteLine(x));
names = new() { "Sam", "Jack", "Joseph" };
WriteLine("Names in uppercase:");
var namesInUppercase = names.Map3(x => x.ToUpper()).ToList();
namesInUppercase.ForEach(x => WriteLine(x.ToUpper()));
#endregion

namespace CustomLibrary
{
    public static class Extensions
    {
        public static List<TResult> Map<TSource, TResult>(this List<TSource> container, Func<TSource, TResult> f)
        {
            List<TResult> output = new();
            //foreach (var item in container)
            //{
            //    output.Add(f(item));
            //}
            container.ForEach(item => output.Add(f(item)));
            return output;
        }
        public static IEnumerable<TResult> Map2<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, TResult> f) // OK
        {
            List<TResult> output = new();
            foreach (var item in container)
            {
                output.Add(f(item));
            }
            // The following line causes error ( IEnumerable does not have ForEach)
            //container.ForEach(item => outputList.Add(f(item))); 
            return output;
        }
        //// using yield return
        ////ERROR CS1624:
        ///* This error occurs if an iterator accessor is used but the return type 
        // * is not one of the iterator interface types: IEnumerable, IEnumerable<T>, IEnumerator, IEnumerator<T>. To avoid this error, use one of the iterator interface types as a return type.
        // * 
        // */
        ////public static List<TResult> Map3<TSource, TResult>(this IList<TSource> list, Func<TSource, TResult> f) //CS 1624
        public static IEnumerable<TResult> Map3<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, TResult> f) // OK
        {
            foreach (var item in container)
                yield return f(item);
        }
    }
}


