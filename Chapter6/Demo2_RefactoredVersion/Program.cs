using static System.Console;
WriteLine("***Refactored version of demonstration 1.***");
VehicleMaker maker = new();
maker.Validate(EngineType.Electric, BodyType.Sports);
enum EngineType
{
    Electric,
    InternalCombustion,
    Hybrid
}
enum BodyType
{
    Sports,
    Standard
}
record class Engine
{
    private EngineType Type { get; }
    //public string Status { get; init; }
    public Engine(EngineType engineType)
    {
        Type = engineType;
    }
    //public Engine(EngineType engineType, string engineStatus = "not set")
    //{
    //    Type = engineType;
    //    Status = engineStatus;
    //}
    //public void Install()
    //{
    //    Status = "installed"; //Error if you use init accessor
    //}

    public override string ToString()
    {
        //return Type.ToString();
        return $"{Type} engine is installed";
    }
}
record class Vehicle
{
    private BodyType Body { get; }
    private Engine Engine { get; }
    public bool LicenseStatus { get; set; }
    public Vehicle(BodyType body, Engine engine, bool licenseStatus = false)
    {
        Body = body;
        Engine = engine;
        LicenseStatus = licenseStatus;
    }
    public void AddLicence()
    {
        LicenseStatus = true;
    }

    public override string ToString()
    {
        return $"""
               The vehicle's description:
               Engine: {Engine}  
               Body: {Body} 
               The license status: {LicenseStatus}
               """;
    }
}
class VehicleMaker
{
    Engine InstallEngine(EngineType engineType)
    {
        //return new Engine(engineType) with { Status = "installed" };
        return new Engine(engineType);
    }
    Vehicle CompleteBody(BodyType bodyType, Engine engine)
    {
        return new Vehicle(bodyType, engine);
    }
    Vehicle AddLicense(Vehicle vehicle)
    {
        return vehicle with { LicenseStatus = true };
    }
    void Display(Vehicle vehicle)
    {
        Output.ShowStatus(vehicle);
    }
    public void Validate(EngineType engineType, BodyType bodyType)
    {
        // The following calling sequence is OK
        Engine engine = InstallEngine(engineType);
        Vehicle vehicle = CompleteBody(bodyType, engine);
        vehicle = AddLicense(vehicle);

        //// The following calling sequence causes compile-time error
        //Vehicle vehicle = CompleteBody(bodyType, engine);
        //Engine engine = InstallEngine(engineType);
        //vehicle = AddLicense(vehicle);

        ////  The following calling sequence causes compile-time errors too   
        //Vehicle vehicle = AddLicense(vehicle);
        //vehicle = CompleteBody(bodyType, engine);
        //Engine engine = InstallEngine(engineType);

        Display(vehicle);
        // Some other code, if any
    }
}
class Output
{
    public static void ShowStatus(Vehicle vehicle)
    {
        WriteLine(vehicle);
    }
}

