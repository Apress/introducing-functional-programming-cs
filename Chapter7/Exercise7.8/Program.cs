using static System.Console;
WriteLine("Exercise 7.8");
List<int> list1 = Enumerable.Range(1, 3).ToList();
List<int> list2 = Enumerable.Range(4, 2).ToList();
var result = list1.SelectMany(x => list2.Select(y => x * y));
result.ToList().ForEach(x=> Write(x+" "));

