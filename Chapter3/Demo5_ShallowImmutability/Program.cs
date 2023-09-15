using static System.Console;
WriteLine("Understanding Shallow Immutability.");
//Employee emp1 = new("Sam", 1);
//Employee emp2 = new("Bob", 2);
//Employee emp3 = new("Jack", 3);
List<Employee> mathEmployees = new()
{
    new("Sam", 1),
    new("Bob", 2)
};

Department mathDept = new("Mathematics", mathEmployees);
WriteLine($"Employee count:{mathDept.Employees.Count}");
// We cannot mutate the state directly,
// but we can do the same using
// the Employees property

//mathDept.Name = "Physics";// Error CS0200
//mathDept.Employees = null; //  Error CS0200
mathDept.Employees.Add(new("Jack", 3)); // OK
WriteLine($"Employee count:{mathDept.Employees.Count}");
mathEmployees.Add(new("Kate", 4));// Also OK
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
    public List<Employee> Employees { get; }
    public Department(string name, List<Employee> emps)
    {
        Name = name;
        Employees= emps;              
    }
}