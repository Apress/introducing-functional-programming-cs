using static System.Console;
WriteLine("Exploring the popsicle immutability( Demo9)");
Employee emp = new("Sam", 1);
WriteLine($"Employee detail: {emp}");
emp.Id = 2; // OK
WriteLine($"Employee detail: {emp}");
emp.Id = 3; // No Change
WriteLine($"Employee detail: {emp}");
emp.Id = 4; // No Change
WriteLine($"Employee detail: {emp}");

class Employee
{
    public string Name { get; }
    private int id;
    private static int AttemptToIdChanged = 1;
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            if (AttemptToIdChanged < 3)
            {
                id = value;
                WriteLine($"The employee Id is created.");
            }
            else
            {
                Console.WriteLine($"""
                    The id cannot be changed. (Maximum limit is reached).
                    You have attempted to changed the id {AttemptToIdChanged} times.                    
                    """);                
            }
            AttemptToIdChanged++;      
        }
    }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override string ToString()
    {
        return $"Name: {Name}, ID:{Id}\n";
    }
}
