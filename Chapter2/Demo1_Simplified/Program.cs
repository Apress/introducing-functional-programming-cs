using static System.Console;
WriteLine("Evaluating the function: f(x)= 2x");

//List<int> domainSet = new() { 1, 3, 7, 12, 15 };
List<int> domainSet = Enumerable.Range(1, 5).ToList();
Write("Domain:[ ");
//foreach (int i in domainSet)
//{
//    Write(i + "\t");
//}
domainSet.ForEach(x => Write(x + "\t"));
Write("]");

WriteLine();

Write("\nRange:[ ");
//foreach (int i in domainSet)
//{
//    Write(i * 2 + "\t");
//}
domainSet.ForEach(x => Write(x * 2 + "\t"));
Write("]\n");

// Q&A 2.1

WriteLine("\nUsing Parallel.ForEach");
Parallel.ForEach(domainSet, x => Write(x + "\t"));

WriteLine("\nOdd numbers in the list are as follows:");
domainSet.Where(i => i % 2 != 0)
         .ToList()
         .AsParallel()
         .ForAll(x => Write(x + "\t"));
