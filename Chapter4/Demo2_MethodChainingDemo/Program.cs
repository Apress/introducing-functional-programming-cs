using static System.Console;

WriteLine("Assembling a PC. (Using method chaining.)");

PcAssembler assembler = new PcAssembler(false, false, false)
                           .ConfigureMotherboard()
                           .ConfigureCpu()
                           .AddOtherParts();
WriteLine(assembler);

//PcAssembler assembler3 = new PcAssembler(false, false, false)
//                           .ConfigureMotherboard()
//                           .AddOtherParts();
//WriteLine(assembler2); //  The PC is not ready yet.

//PcAssembler assembler3 = new PcAssembler(false, false, false)
//                           .ConfigureCpu()
//                           .ConfigureMotherboard()
//                           .AddOtherParts();
//WriteLine(assembler3);
class PcAssembler
{
    bool IsMotherboardReady { get; }
    bool IsCpuReady { get; }
    bool IsOtherpartsReady { get; }
    public PcAssembler(bool motherBoard, bool cpu, bool otherParts)
    {
        IsMotherboardReady = motherBoard;
        IsCpuReady = cpu;
        IsOtherpartsReady = otherParts;
    }
    public PcAssembler ConfigureMotherboard()
    {
        WriteLine("The motherboard is added.");
        return new PcAssembler(true, IsCpuReady, IsOtherpartsReady);
    }
    public PcAssembler ConfigureCpu()
    {
        WriteLine("The CPU is configured.");
        return new PcAssembler(IsMotherboardReady, true, IsOtherpartsReady);
    }
    public PcAssembler AddOtherParts()
    {
        WriteLine("All parts(except the CPU and motherboard) are configured.");
        return new PcAssembler(IsMotherboardReady, IsCpuReady, true);
    }
    public override string ToString() =>
        IsMotherboardReady
        && IsCpuReady
        && IsOtherpartsReady
           ? "The PC is complete now."
           : "The PC is not ready yet.";
}

