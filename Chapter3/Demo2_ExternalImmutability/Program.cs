using static System.Console;
WriteLine("Understanding Mutability and Immutability.");
Employee emp1 = new("Sam", 1);
WriteLine(emp1);
//emp1.Id = 2;// Error CS0272
Employee temp = emp1;
WriteLine($"The emp1's hashcode:{emp1.GetHashCode()}");
WriteLine($"The temp's hashcode:{temp.GetHashCode()}");

// To change Sam's ID, we create a new object
emp1 = new("Sam", 2);
WriteLine(emp1);
WriteLine($"The emp1's hashcode:{emp1.GetHashCode()}");
WriteLine($"The temp's hashcode:{temp.GetHashCode()}");
class Employee
{
    public string Name { get; private set; }
    public int Id { get; private set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public override string ToString() => $"Name: {Name}, ID: {Id}";
}