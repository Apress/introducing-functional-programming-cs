using static System.Console;
using Extensions;
WriteLine("Experimenting with an arbitrary function.");
Dictionary<int, int> multiplyByTwo = new()
{
    {1,2 },
    {2,4 },
    {3,6 },
    {4,8 },
    {5,10 }
};
#region For Demo 3

for (int i = 1; i <= multiplyByTwo.Count; i++)
{
    WriteLine($"f({i})={multiplyByTwo[i]}");
}
#endregion

WriteLine("----");

#region For Demo 4

multiplyByTwo.ForEach(x => WriteLine($"f({x.Key})={x.Value}"));

namespace Extensions
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            if (action != null)
            {
                foreach (T item in sequence)
                {
                    action(item);
                }
            }
        }
    }
}
#endregion






