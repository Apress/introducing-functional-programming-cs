using static System.Console;
using System.Collections.Immutable;

WriteLine("Improving the shallow immutability using an immutable list.)");
//Employee emp1 = new("Sam", 1);
//Employee emp2 = new("Bob", 2);

List<Employee> mathEmployees = new()
{
    new("Sam", 1),
    new("Bob", 2)
};

//MathDept mathDept = new("Mathematics", mathEmployees);
var immutableMathEmployees = mathEmployees.ToImmutableList();
WriteLine($"Initial count in the immutable list:{immutableMathEmployees.Count}");//2
WriteLine($"Forming the Math department with an immutable list of employees.");
Department mathDept = new("Mathematics", immutableMathEmployees);
WriteLine($"Employee count in the Math department:{mathDept.Employees.Count}");//2

// We cannot mutate the state directly,
// mathDept.Name = "Physics";// Error CS0200
// mathDept.Employees = null; //  Error CS0200
// var updatedMathDept1 = mathDept.Employees.Add(new("Jack", 3));

WriteLine($"Adding Jack to the Math department");
Department updatedMathDept = new("Mathematics", mathDept.Employees.Add(new("Jack", 3)));
WriteLine($"Employee count in new department:{updatedMathDept.Employees.Count}");// 3

WriteLine($"Adding Kate to the initial list.");
var updatedMathEmployees=immutableMathEmployees.Add(new("Kate", 4));
WriteLine($"Employee count in the updated list:{updatedMathEmployees.Count}");// 3

WriteLine($"Employee count:{mathDept.Employees.Count}");// still 2
WriteLine($"Employee count:{immutableMathEmployees.Count}");// still 2
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
    //public IReadOnlyCollection<Employee> Employees { get; }
    public ImmutableList<Employee> Employees { get; }
    public Department(string name, ImmutableList<Employee> emps)
    {
        Name = name;
        Employees = emps;
    }
}

