using static System.Console;

WriteLine("Using a HOF that has an Action<int, int> parameter.");
int a = 10, b = 5; 
Action<int, int> add = (x, y) => WriteLine($"{x}+{y}={x + y}");
DisplayTotal(add,a,b);
static void DisplayTotal(Action<int, int> del, int a,int b)
{
    del(a,b);
}

