using static System.Console;
WriteLine("Understanding Mutability.");
Employee emp1 = new("Sam", 1);
WriteLine(emp1);
// Setting the new ID for emp1
emp1.Id = 2;
WriteLine(emp1);

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public override string ToString() => $"Name: {Name}, ID: {Id}";

}
