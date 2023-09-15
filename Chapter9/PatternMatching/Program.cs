using System.Reflection.Metadata.Ecma335;
using static System.Console;


// Example 1 is already discussed in Chapter 8

WriteLine("Example 2");
int? maybe = 25;
//maybe = 5;

string testResult= maybe is int value ?
    $"The 'maybe' holds the value: {value}" :
    "The nullable int 'maybe' doesn't hold a value";
WriteLine(testResult);
WriteLine("-------------");


WriteLine("Example 3");

Person person1 = new() { Name = "John" };
Person person2 = new Employee { Name = "Bob", ID = 1 };

var result1 = person1 is Employee e1 ? $"{e1}" : $"{person1} is not an employee";
WriteLine(result1);
var result2 = person2 is Employee e2 ? $"{e2}" : $"{person2} is not an employee";
WriteLine(result2);

WriteLine("-------------");


WriteLine("Example 4");

var result3=CheckPattern(person1);
WriteLine(result3);
var result4=CheckPattern(person2);
WriteLine(result4);
// Switch expression
string CheckPattern(Person p) => p switch
{
    Employee e => $"{e}",
    _ => $"{p} is not an employee"
};




class Person
{
    public string Name { get; set; }
    public override string ToString() => $"{Name}";    

}
class Employee:Person
{
    //public string Name { get; set; }
    public int ID { get; set; }
    public override string ToString() => $"{Name} is an employee with ID: {ID}";
}