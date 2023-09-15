using static System.Console;
WriteLine("Exercise 1.5 ");
int a = 10;
var square = GetSquareFunction();
WriteLine($"The square of {a} is: {square(a)}");

static Func<int, int> GetSquareFunction()
{    
    //Func<int, int> squareFunction = x => x * x;
    static int squareFunction(int x) => x * x;
    return squareFunction;
    
    //return x => x * x;
}