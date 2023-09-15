using static System.Console;

List<string> names = new() { "Sam","Jo", "Bob" };

WriteLine("Executing query1");
// Using method syntax
var query1 = names
    .Where(name => name.Length > 2)
    .Select(name => name);
query1.ToList().ForEach(WriteLine);

WriteLine("Executing query2");
// Using Query Syntax
var query2 = from name in names
             where name.Length > 2
             select name;
query2.ToList().ForEach(WriteLine);



