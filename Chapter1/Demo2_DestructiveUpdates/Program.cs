using static System.Console;

List<string> names = new() { "Sam", "Bob" };
WriteLine("The list includes the following names:");
//names.ForEach(x => WriteLine(x));
names.ForEach(WriteLine);

// Removing existing names
names.Clear();
// Adding two new names
names.Add("Kate");
names.Add("Jack");

WriteLine("\nThe list includes the following names:");
names.ForEach(x => WriteLine(x));

