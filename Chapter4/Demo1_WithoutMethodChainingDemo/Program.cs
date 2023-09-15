using static System.Console;
//Console.WriteLine("Without method chaining demo.");
WriteLine("Assembling a PC.");
PcAssembler assembler = new(false, false, false);
//PcAssembler assembler = new(default, default, default); // OK too
assembler.ConfigureMotherboard();
//WriteLine(assembler);
assembler.ConfigureCpu();
//WriteLine(assembler);
assembler.AddOtherParts();
WriteLine(assembler);

class PcAssembler
{
    bool IsMotherboardReady { get; set; }
    bool IsCpuReady { get; set; }
    bool IsOtherpartsReady { get; set; }
    public PcAssembler(bool motherBoard, bool cpu, bool otherParts)
    {
        IsMotherboardReady = motherBoard;
        IsCpuReady = cpu;
        IsOtherpartsReady = otherParts;
    }
    public void ConfigureMotherboard()
    {
        WriteLine("The motherboard is added.");
        IsMotherboardReady = true;
    }
    public void ConfigureCpu()
    {
        WriteLine("The CPU is configured.");
        IsCpuReady = true;
    }
    public void AddOtherParts()
    {
        WriteLine("All parts(except the CPU and motherboard) are configured.");
        IsOtherpartsReady = true;
    }
    public override string ToString()
    {
        if (IsMotherboardReady && IsCpuReady && IsOtherpartsReady)
        {
            return "The PC is complete now.";
        }
        else
        {
            return "The PC is not ready yet.";
        }
        //return IsMotherboardReady
        //    && IsCpuReady
        //    && IsOtherpartsReady
        //      ? "The PC is complete now."
        //      : "The PC is not ready yet.";
    }
}
