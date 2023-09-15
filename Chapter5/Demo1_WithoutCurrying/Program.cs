using static System.Console;
WriteLine("Analyzing a non-curried function.");
int a = 10, b = 2;
int result = new Sample().AddTwoNumbers(a, b);
//int result = new Sample().AddTwoNumbers(a);// Error CS7036
WriteLine($"{a}+{b} is {result}");

class Sample
{
    public Func<int, int, int> AddTwoNumbers = (int first, int second) => first + second;   
}

