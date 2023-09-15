using static System.Console;

List<int> input = Enumerable.Range(1, 5).ToList();
WriteLine("The list contains:");
input.ForEach(WriteLine);

WriteLine("Making a square of each element:");
input.Select(x => x * x)
     .ToList()
     .ForEach(WriteLine);

WriteLine("Increasing each number in the original list by 3:");
input.Select(x => x + 3)
     .ToList()
     .ForEach(WriteLine);

List<string> names = new() { "Sam", "Jack", "Joseph" };
WriteLine("Names in uppercase:");
names.Select(x => x.ToUpper())
    .ToList()
    .ForEach(x => WriteLine(x.ToUpper()));



