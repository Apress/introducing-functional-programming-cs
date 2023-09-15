using static System.Console;
WriteLine("Exercise 5.2");
Func<int, Func<int, string>> compare = x => y => (x > y ? $"{x} is greater" : $"{y} is greater");
string result=compare(23)(12);
WriteLine(result);
result = compare(23)(37);
WriteLine(result);

