using Extentions;
using static System.Console;

WriteLine("Exercise 4.5");

WriteLine("Use case-1:");
PcAssembler assembler = new PcAssembler(false, false, false)
                           .ConfigureMotherboard()
                           .ConfigureCpu()
                           .AddOtherParts()
                           .GetServiceCharge();
WriteLine(assembler);

WriteLine("\nUse case-2:");
assembler = new PcAssembler(false, false, false)
               .ConfigureCpu()
               .AddOtherParts()
               .GetServiceCharge();
WriteLine(assembler);
class PcAssembler
{
    bool IsMotherboardReady { get; }
    bool IsCpuReady { get; }
    bool IsOtherpartsReady { get; }
    public PcAssembler(bool motherBoard,
                       bool cpu,
                       bool otherParts)
    {
        IsMotherboardReady = motherBoard;
        IsCpuReady = cpu;
        IsOtherpartsReady = otherParts;
    }
    public PcAssembler ConfigureMotherboard()
    {
        WriteLine("Motherboard is added.");
        return new PcAssembler(true, IsCpuReady,
          IsOtherpartsReady);
    }
    public PcAssembler ConfigureCpu()
    {
        WriteLine("The CPU is configured.");
        return new PcAssembler(IsMotherboardReady, true,
          IsOtherpartsReady);
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
namespace Extentions
{
    static class PcAssemblerExtention
    {
        public static PcAssembler GetServiceCharge(this
          PcAssembler assembler)
        {
            WriteLine("A service charge is generated.");
            return assembler;
        }
    }
}


