using static System.Console;

WriteLine("Evaluating f(x)= 2x using delegates.");
List<int> domainSet = new() { 1, 2, 3, 4, 5 };
Action<int> displayNumbers = x => Write(x + "\t");

Write("Domain: [");
// Passing the delegate as a function argument
domainSet.ForEach(displayNumbers);
Write("]");

WriteLine();

Action<int> multiplyByTwo = x => Write(x * 2 + "\t");
Write("Range: [");
// Passing the delegate as a function argument
domainSet.ForEach(multiplyByTwo);
WriteLine("]");


