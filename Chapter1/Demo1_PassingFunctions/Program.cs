using static System.Console;

int temp = 5;
Func<int, int> doubleMaker = x => x * 2;
int result = Container.GetResult(doubleMaker, temp);
WriteLine(result);

static class Container
{
    public static int GetResult(Func<int, int> f, int x)
    {
        return f(x);
    }
}
