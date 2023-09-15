using static System.Console;


(int,double,string) tuple = (3,7.5, "hello");
//var tuple = (3, 7.5, "hello");
WriteLine($"""
 1st element: {tuple.Item1}
 2nd element: {tuple.Item2}
 3rd element: {tuple.Item3}
 """);
WriteLine(tuple.GetType());

WriteLine("----------");


//Tuple<string, string> name = Tuple.Create("Sumit", "Jain"); //Ok
////Tuple< string firstName, string lastName> name= Tuple.Create("Sumit", "Jain"); // Error
///
(string fName, string lName) fullName= ("Sumit", "Jain"); // OK
WriteLine($"First name: {fullName.fName} Last name: {fullName.lName}");
WriteLine($"Type: {fullName.GetType()}");
WriteLine("----------");

var details = Circle.GetDetails(10);
WriteLine($"Circumference:{details.Item1} unit.");
WriteLine($"Area: {details.Item2} sq.unit.");
WriteLine("----------");


Circle circle2 = new()
{
    Radius = 10
};
var details2 = circle2.Details;
WriteLine($"Circumference:{details2.Circumference} unit.");
WriteLine($"Area: {details2.Area} sq.unit.");


//// Old style
//class Circle
//{
//    static internal Tuple<double, double> GetDetails(double radius)
//    {
//        return Tuple.Create(2 * 3.14 * radius, 3.14 * radius * radius);
//    }
//}

class Circle
{
    // Using method
    static internal (double perimeter,double area) GetDetails(double radius)
    {
        return (2 * 3.14 * radius, 3.14 * radius * radius);
    }

    // Using property
    public double Radius { get; set; }
    public (double Circumference, double Area) Details => (2 * 3.14 * Radius, 3.14 * Radius * Radius);
}




