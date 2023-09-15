using static System.Console;
//WriteLine("Exercises 6.4 Refactored.");

WriteLine("Executing the refactored version:");
new JobService2().Execute();
record class ComplexJob
{
    public bool partOneFinished, partTwoFinished;
    public ComplexJob(bool partOne = false, bool partTwo = false)
    {
        partOneFinished = partOne;
        partTwoFinished = partTwo;
    }

}

record class JobService2
{
    ComplexJob Initiate()
    {
        return new ComplexJob();
    }
    ComplexJob ExecutePartOne(ComplexJob job)
    {
        // Some code to finish Part 1       
        return job with { partOneFinished = true };
    }
    ComplexJob ExecutePartTwo(ComplexJob job)
    {
        // Part 2 can be executed only after Part 1.
        return job with { partTwoFinished = true };
    }
    void PrintStatus(ComplexJob job)
    {
        string Status = job.partOneFinished && job.partTwoFinished
                        ? "The process is completed successfully."
                        : "Process is incomplete.";
        WriteLine(Status);
    }
    public void Execute()
    {
        // This calling sequence is OK
        ComplexJob job = Initiate();
        ComplexJob afterPartOne = ExecutePartOne(job);
        ComplexJob afterPartTwo = ExecutePartTwo(afterPartOne);
        PrintStatus(afterPartTwo);

        //// This calling sequence will cause a compile-time error.
        //ComplexJob afterPartOne = ExecutePartOne(job);
        //ComplexJob job = Initiate();
        //ComplexJob afterPartTwo = ExecutePartTwo(afterPartOne);
        //PrintStatus(afterPartTwo);
    }
}

