using static System.Console;

WriteLine("Using a HOF that returns an Action<int, int> ");
int a = 20, b = 7;
/*
Action<int, int> result = GetTotalMaker();
result(a,b);

static Action<int, int> GetTotalMaker()
{
    Action<int, int> total = (x, y) => WriteLine($"{x}+{y}= {x + y}");
    return total;    
}
*/

// Short form

GetTotalMaker()(a,b);

static Action<int, int> GetTotalMaker()
{
    //Action<int, int> total = (x, y) => WriteLine($"{x}+{y}= {x + y}");
    //return total;
    return (x, y) => WriteLine($"{x}+{y}= {x + y}");
}
