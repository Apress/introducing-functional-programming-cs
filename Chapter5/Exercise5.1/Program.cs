using static System.Console;
WriteLine("Exercise 5.1");
Func<int, Func<int, Func<int, int>>> sum = x => y => z => x + y + z;
Func<int, Func<int, int>> temp1 = sum(2);
Func<int, int> temp2 = temp1(5);
int result = temp2(7);
WriteLine($"2+5+7={result}");
