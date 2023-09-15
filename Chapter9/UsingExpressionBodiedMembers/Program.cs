using static System.Console;
Employee emp = new("Kevin", "Smith");
//WriteLine($"Employee name: {emp.FullName()}");
WriteLine($"Employee name: {emp.FullName}");

//emp = new("Bob");
//WriteLine($"Employee name: {emp.FullName}");

//class Employee
//{
//    public string FirstName { get; }
//    public string LastName { get; }
//    public Employee(string firstName, string lastName)
//    {
//        FirstName= firstName;
//        LastName= lastName;
//    }

//    public string FullName()
//    {
//        return $"{FirstName} {LastName}";
//    }


//}

//class Employee
//{
//    public string FirstName { get; }
//    public string LastName { get; }
//    public Employee(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }
//    public string FullName() => $"{FirstName} {LastName}";   

//}

//class Employee
//{
//    public string FirstName { get; }
//    public string LastName { get; }
//    public Employee(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }   
//    public string FullName => $"{FirstName} {LastName}";

//}

//class Employee
//{
//    public string FirstName { get; }
//    public string? LastName { get; }
//    public Employee(string firstName) =>
//        FirstName = firstName;

//    //// Error
//    //public Employee(string firstName, string lastname) =>
//    //{
//    //     FirstName = firstName;
//    //     LastName=lastName;
//    //}

//    public Employee(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }

//    public string FullName => $"{FirstName} {LastName}";

//}

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //// Not a recommended approach
    //public Employee(string firstName, string lastname) =>
    //    SetName(firstName, lastname);

    //void SetName(string firstName, string lastName)
    //{
    //    FirstName = firstName;
    //    LastName = lastName;
    //}

    // Better approach
    public Employee(string firstName, string lastname) =>
     (FirstName, LastName) = (firstName, lastname);
    public string FullName => $"{FirstName} {LastName}";

}