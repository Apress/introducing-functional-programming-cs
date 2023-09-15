using static System.Console;

WriteLine("Exercise 2.6");
Action<int, int> add =
    (x, y) => WriteLine($"{x} + {y} = {x + y}");
Func<Action<int, int>> makeTotal = () =>
{
    WriteLine("The makeTotal function is called.");
    return add;
};
makeTotal()(10, 15);
// Same as:
Action<int, int> action = makeTotal();
action(10, 15);

