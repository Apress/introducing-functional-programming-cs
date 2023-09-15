using System.Text;
using static System.Console;
WriteLine("Piepelining using in-built constructs in C#.");
WriteLine("Example-1");
//StringBuilder builder = new("Hello, ");
//int length = builder.Append("reader! How are you")
//                    .Insert(builder.Length, "?")
//                    .Length;

StringBuilder builder = new("Hello, ");
int length = builder.Append("reader! How are you")
                    .Insert(builder.Length, "?")
                    .Length;
WriteLine($"The string is: {builder}");
WriteLine($"Its length is: {length}");


WriteLine("\nExample-2");
List<int> numbers = new() { 10, 21, 6, 14, 9 };
WriteLine("Even numbers in increasing order:");
numbers.Where(i => i % 2 == 0)
       .OrderBy(x => x)
       .ToList()
       .ForEach(WriteLine);

