using static System.Console;

WriteLine("Analyzing destructive updates.");

List<string> names = new() { "Sam", "Kate" };
WriteLine("The list includes the following:");
names.ForEach(x => WriteLine($"Name: {x},length:{x.Length}"));

int random = new Random().Next(0, 2);
string? newName = random > 0 ? "Jack" : null;
// Adding a new name
names.Add(newName);
WriteLine("\nThe list includes the following names:");
names.ForEach(x => WriteLine($"Name: {x},length:{x.Length}"));

