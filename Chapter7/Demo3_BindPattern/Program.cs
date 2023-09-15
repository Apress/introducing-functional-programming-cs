using CustomLibrary;
using static System.Console;

WriteLine("Testing the bind pattern.");
var salesDept = new Department { Name = "Sales", Ids = new List<string> { "S1", "S2" } };
var productDept = new Department { Name = "Production", Ids = new List<string> { "P1", "P2", "P3" } };

var company = new List<Department> { salesDept, productDept };
WriteLine("The company has assigned the following ids:");

//WriteLine("Following imperative style:");
//// Imperative style
//var salesIds = salesDept.Ids;
//var productIds = productDept.Ids;
//var allIds = salesIds.Concat(productIds);
//foreach (var id in allIds)
//{
//    WriteLine(id);
//}

// Using custom function
WriteLine("Using the custom function, called Bind now.");
company.Bind(x => x.Ids)
       .ToList()
       .ForEach(WriteLine);


class Department
{
    public string Name { get; set; }
    public List<string> Ids { get; set; }
}
namespace CustomLibrary
{
    public static class Extensions
    {
        public static IEnumerable<TResult> Bind<TSource, TResult>(this IEnumerable<TSource> container, Func<TSource, IEnumerable<TResult>> f)
        {
            foreach (var outerItem in container)
                foreach (var innerItem in f(outerItem))
                    yield return innerItem;
        }        
    }
}



