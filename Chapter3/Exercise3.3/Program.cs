using static System.Console;
//WriteLine("Exercise 3.3");
Circle circle = new(7.5, "Red");
WriteLine($"Current detail: {circle}");
circle.IncrementRadiusBy(2);
WriteLine($"Current detail: {circle}");

class Circle
{
    public double Radius { get; set; }
    public string Color { get; set; }
    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }
    public void IncrementRadiusBy(int r)
    {
        Radius += r;
    }
    public override string ToString()=>
     $"Radius:{Radius} units, Color: {Color}";   
  
}
