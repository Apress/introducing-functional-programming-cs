using static System.Console;
// Discussions Prior to Demo 3 are shown at the end of the file

WriteLine("Achieving Internal Immutability.");
Employee emp1 = new("Sam", 1);
// emp1.Id = 2;// Error Now
Employee emp2 = emp1.SetNewId(2); // OK

WriteLine($"Emp1: {emp1}");
WriteLine($"Emp2: {emp2}");

class Employee
{
    public string Name { get; }
    public int Id { get; }
    //public int Id { get; private set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    //public void SetNewId(int id)
    //{
    //    Id = id;// Error CS0200
    //}
    public Employee SetNewId(int id)
    {
        // Creating a new object with an
        // existing name and supplied id
        return new Employee(Name, id);
    }

    public override string ToString() =>
      $"Name: {Name}, ID: {Id}";

}

/*
WriteLine("Understanding Mutability and Immutability( Discussions prior to Demo3)");  
// External Immutability is NOT Sufficient
Employee emp1 = new("Sam", 1);
WriteLine(emp1);
//emp1.Id = 2;// Error Now

// We can change the ID by calling ChangeID
emp1.SetNewId(2);// Doesn't show error
WriteLine(emp1);

class Employee
{
    public string Name { get; private set; }
    public int Id { get; private set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public void SetNewId(int id)
    {
        Id = id;
    }
    public override string ToString() =>
      $"Name: {Name}, ID: {Id}";
}
*/
