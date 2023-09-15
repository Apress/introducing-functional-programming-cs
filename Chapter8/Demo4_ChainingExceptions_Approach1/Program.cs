using LanguageExt;
using static System.Console;

IO.Display("***Chaining functions that can raise errors.***");

// Creating two employees
Employee emp1 = new(id: "E1", salary: 12000);
Employee emp2 = new(id: "E2", salary: 16000.75);

// Proposing a hike percentage
int proposedHike = new Random().Next(8, 15);

// Verifying the promotion eligibility and proposed hike
IO.Verify(emp1 with { Hike = proposedHike });
IO.Verify(emp2 with { Hike = proposedHike });


record class Employee
{
    public string Id { get; }
    public double Salary { get; }
    public string PromotionStatus { get; init; }
    public int Hike { get; init; }

    public Employee(
      string id,
      double salary,
      int hike = 0,
      string promotionStatus = "yet to verify"
      )
    {
        Id = id;
        Salary = salary;
        Hike = hike;
        PromotionStatus = promotionStatus;
    }
    public override string ToString()
    {
        return $"{Id}'s current salary is ${Salary}.";
    }
}

static class HrManager
{
    public static Either<Exception, Employee> CheckSalary(Employee emp)
    {
        // Checking the promotion criteria.
        // Fail, if the current salary is more than $15000
        return emp.Salary > 15000
         ? new Exception($"the current salary exceeds $15000.")
         : emp with { PromotionStatus = "Eligible" };
    }
    public static Either<Exception, Employee> ProposeHike(Employee emp)
    {
        // Verifying the proposed hike for the employee.
        // Fail, if the proposed hike is less than 10%
        return emp.Hike < 10
         ? new Exception($"the proposed hike is {emp.Hike}% which is less than 10%.")
         : emp with { PromotionStatus = "Eligible" };
    }
}
static class IO
{
    public static void Display(object? msg)
    {
        WriteLine(msg);
    }
    public static void Verify(Employee emp)
    {
        HrManager.CheckSalary(emp).Match(
         Right: (Employee emp) =>
         {
             Display(emp);
             // The CheckSalary function successfully executes;
             // so, evaluating the next function.
             HrManager.ProposeHike(emp).Match(
               Right: (Employee emp) =>
               {
                   Display($"He/she is eligible for a promotion. Proposed hike: {emp.Hike}%");
               },
               Left: (Exception e) =>
               {
                   Display($"Recheck the hike proposal: {e.Message}");
               }
          );
         },
         Left: (Exception e) =>
         {
             Display($"{emp}Cannot promote the employee: {e.Message}");
         }
      );
    }
}

