using static System.Console;

Circle circle = new(10);
WriteLine($"Radius: {circle.Radius} unit.");
WriteLine($"Circumference: {circle.GetCircumference()} unit");
WriteLine($"Area: {circle.GetArea()} square unit.");

class Circle
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; }
    
    public double GetCircumference()
    {
        static double MakeDouble(double value) => 2 * value;
        return 3.14* MakeDouble(Radius);
    }

    public double GetArea()
    {
        static double MakeSquare(double value) => value * value;
        return 3.14 * MakeSquare(Radius);
    }
}
