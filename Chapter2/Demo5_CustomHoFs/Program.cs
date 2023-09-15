using static System.Console;

WriteLine("Example of HOFs using Func delegate.");
int a = 10; ;
Func<int, int> squareFunction = x => x * x;
ShowSquare(squareFunction, a);

int result = MakeSquare()(a + 2);
WriteLine($"The square of {a + 2} is: {result}");

static void ShowSquare(Func<int, int> func, int a)
{
    int result = func(a);
    WriteLine($"The square of {a} is: {result}");
}
static Func<int, int> MakeSquare()
{
    //Func<int, int> squareFunction = x => x * x;
    // Example of local function
    static int squareFunction(int x) => x * x;
    return squareFunction;
    //return x => x * x;
}

