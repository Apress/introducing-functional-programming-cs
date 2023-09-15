using static System.Console;
var numbers = Enumerable.Range(10, 7).ToList();
Func<int, bool> isMod(int n) => x => x % n == 0;
//// Finding the multipliers of 2(Even Numbers)
//Func<int, bool> isEven = x => x % 2 == 0;
WriteLine("Multipliers of 2(Even Numbers):");
numbers.Where(isMod(2))
       .ToList()
       .ForEach(WriteLine);

WriteLine("Multipliers of 3:");
numbers.Where(isMod(3))
       .ToList()
       .ForEach(WriteLine);

WriteLine("Multipliers of 5:");
numbers.Where(isMod(5))
       .ToList()
       .ForEach(WriteLine);
