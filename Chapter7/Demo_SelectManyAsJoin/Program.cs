using static System.Console;
WriteLine("Using the SelectMany function for joining lists.");
var setA = Enumerable.Range(1, 2).ToList();
var setB = Enumerable.Range(3, 3).ToList();
WriteLine("\nThe set A contains :");
setA.ForEach(x => Write(x + "\t"));

WriteLine("\nThe set B contains:");
setB.ForEach(x => Write(x + "\t"));

WriteLine("\nThe cartesian product:");
setA.SelectMany(x => setB.Select(y => $"({x},{y})"))
    .ToList()
    .ForEach(x => Write(x + "\t"));

