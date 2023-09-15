// THIS IS NO MORE EXERCISE 7.4.
using CustomLibrary;
using static System.Console;
WriteLine("Exercise 7.4");
var salesDept = new Department { Name = "Sales", Ids = new List<string> { "S1", "S2" } };
var productDept = new Department { Name = "Product", Ids = new List<string> { "P1", "P2", "P3" } };

var company = new List<Department> { salesDept, productDept };
WriteLine("The company has assigned the following ids:");


// Using custom function
WriteLine("Using the custom function, called Bind now.");
company.Bind(x => x.Ids)
       .ToList()
       .ForEach(x => WriteLine(x));


WriteLine("Using in-built function: SelectMany now.");
company.SelectMany(x => x.Ids)
        .ToList()
        .ForEach(x => WriteLine(x));



class Department
{
    public string Name { get; set; }
    public List<string> Ids { get; set; }
}
namespace CustomLibrary
{
    public static class Extensions
    {
        //public static IEnumerable<TResult> Bind<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, IEnumerable<TResult>> f)
        //{

        //    foreach (var outerItem in container)
        //        foreach (var innerItem in f(outerItem))
        //            yield return innerItem;
        //}

        public static IEnumerable<TResult> Bind<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, IEnumerable<TResult>> f)
        {
            return container.SelectMany(f);
        }

    }
}




