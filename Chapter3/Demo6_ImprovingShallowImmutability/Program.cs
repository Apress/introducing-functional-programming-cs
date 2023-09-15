using static System.Console;
WriteLine("Improving the shallow immutability.");
//Employee emp1 = new("Sam", 1);
//Employee emp2 = new("Bob", 2);
List<Employee> mathEmployees = new()
{
    new("Sam", 1),
    new("Bob", 2)
};

Department mathDept = new("Mathematics", mathEmployees);
WriteLine($"Employee count:{mathDept.Employees.Count}");

// We cannot mutate the state directly
// mathDept.Name = "Physics";// Error CS0200
// mathDept.Employees = null; //  Error CS0200

// Now the following line will raise a compile-time error
//mathDept.Employees.Add(new("Jack", 3)); // Error 1061 now

// Still, the following line shows no compile-time error
mathEmployees.Add(new("Kate", 4));
WriteLine($"Employee count:{mathDept.Employees.Count}");

class Employee
{
    public string Name { get; }
    public int Id { get; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public override string ToString() =>
     $"Name: {Name}, ID: {Id}";

}
class Department
{
    public string Name { get; }
    //public List<Employee> Employees { get; }
    public IReadOnlyCollection<Employee> Employees { get; }
    public Department(string name, IReadOnlyCollection<Employee> emps)
    {
        Name = name;
        Employees = emps;
    }
}
