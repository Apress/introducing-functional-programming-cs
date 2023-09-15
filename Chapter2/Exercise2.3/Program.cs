using static System.Console;
var numbers = Enumerable.Range(10, 7).ToList();
Func<int, bool> isEven = x => x % 2 == 0;
numbers.Where(isEven)     
       .ToList()
       .ForEach(x => WriteLine(x));


