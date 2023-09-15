using static System.Console;


WriteLine("***Experimenting Temporal Coupling.***");
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
class Engine
{
    private EngineType Type { get; }
    public string Status { get; set; }
    public Engine(EngineType engineType, string engineStatus = "not set")
    {
        Type = engineType;
        Status = engineStatus;
    }
    public void Install()
    {
        Status = "installed";

    }
    public override string ToString()
    {
        //return Type.ToString();
        return $"{Type} engine is {Status}";
    }
}
class Vehicle
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
               License status: {LicenseStatus}
               """;
    }
}
class VehicleMaker
{
    private Engine _engine;
    private Vehicle _vehicle;
    void InstallEngine(EngineType engineType)
    {
        _engine = new Engine(engineType);
    }

    void CompleteBody(BodyType bodyType)
    {
        // Install the engine before working on the vehicle body.
        _engine.Install();
        //_engine?.Install();
        _vehicle = new Vehicle(bodyType, _engine);
    }
    void AddLicense()
    {
        _vehicle.AddLicence();
        //_vehicle?.AddLicence();
    }
    void Display(Vehicle vehicle)
    {
        Output.ShowStatus(vehicle);
    }
    public void Validate(EngineType engineType, BodyType bodyType)
    {
        //// The following calling sequence is OK
        //InstallEngine(engineType);
        //CompleteBody(bodyType);
        //AddLicense();

        //// The following calling sequence causes the run-time error        
        //CompleteBody(bodyType);
        //InstallEngine(engineType);
        //AddLicense();

        //// The following calling sequence also causes the run-time error
        //AddLicense();
        //CompleteBody(bodyType);
        //InstallEngine(engineType);

        Display(_vehicle);
        //Some other code, if any
    }
}
class Output
{
    public static void ShowStatus(Vehicle vehicle)
    {
        WriteLine(vehicle);
    }
}

