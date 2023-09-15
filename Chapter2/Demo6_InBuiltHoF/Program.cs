using System.Linq;
using static System.Console;

var numbers = Enumerable.Range(1, 10);
WriteLine("Even numbers in the list are as follows:");
numbers.Where(i => i % 2 == 0)
       .ToList()
       .ForEach(x => Write(x + "\t"));


