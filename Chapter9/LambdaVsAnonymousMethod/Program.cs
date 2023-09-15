using static System.Console;

const int a = 1, b = 2;
// Using Anonymous method (C# 2.0 onwards)
WriteLine("Using an anonymous delegate:");
Func<int,int,int> result1= delegate (int x, int y) { return x + y; };
WriteLine($"{a}+{b}= {result1(a,b)}");


// Using a lambda expression(C# 3.0 onwards)
WriteLine("Using a lambda expression:");
Func<int, int, int> result2 = (x, y) => x + y;
WriteLine($"{a}+{b}= {result2(a, b)}");



Action sayHello = delegate { WriteLine("Hello, reader!"); };
sayHello();
Action <string,int> sayWelcome = delegate { WriteLine("Welcome, reader!"); };
sayWelcome("abc",7);



