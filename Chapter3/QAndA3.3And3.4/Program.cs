Employee emp = new("Sam", 1);
//emp.Name = "Jack";// Error CS0200
//emp.Id = 2;// Error CS0200

class Employee
{
    public string Name { get; }
    public int Id { get; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public override string ToString()
    {
        return $"Name: {Name}, ID:{Id}";
    }
}
