using static System.Console;

WriteLine("Testing the bind pattern.");
var salesDept = new Department { Name = "Sales", Ids = new List<string> { "S1", "S2" } };
var productDept = new Department { Name = "Production", Ids = new List<string> { "P1", "P2", "P3" } };
var company = new List<Department> { salesDept, productDept };
WriteLine("The company has assigned the following ids:");
company.SelectMany(x => x.Ids)
        .ToList()
        .ForEach(WriteLine);
class Department
{
    public string Name { get; set; }
    public List<string> Ids { get; set; }
}




