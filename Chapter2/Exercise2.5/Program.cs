using static System.Console;

WriteLine("Exercise 2.5");
Func<int, int> triple = x => x * 3;   
Action<Func<int,int>, int> tripleMaker = ( Func<int, int> f,int x ) =>
{
    WriteLine($"Triple of {x} is: {f(x)} ");   
};
tripleMaker(triple, 10);


