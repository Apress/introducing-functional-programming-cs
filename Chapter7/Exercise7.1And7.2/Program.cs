using static System.Console;
WriteLine("Exercise 7.1 and 7.2");
Action action=() => WriteLine("Hello");
action();

Func<string,int,string> func=(string s,int i) => $"{s} was published in {i}";
var input=func("This book", 2023);
WriteLine(input);