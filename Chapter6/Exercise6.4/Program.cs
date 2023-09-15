using static System.Console;

//WriteLine("Exercises.");
//WriteLine("Executing the initial version:");
new JobService().Execute();

class ComplexJob
{
    public bool partOneFinished, partTwoFinished;
    public ComplexJob(bool partOne = false, bool partTwo = false)
    {
        partOneFinished = partOne;
        partTwoFinished = partTwo;
    }

}


class JobService
{
    ComplexJob? _job;
    void Initiate()
    {
        _job = new ComplexJob();
    }
    void ExecutePartOne()
    {
        // Some code to finish Part 1       
        _job.partOneFinished = true;
    }
    void ExecutePartTwo()
    {
        // Part 2 can be executed only after Part 1.
        // Some code to finish part 2  
        // _job.partTwoFinished = _job.partOneFinished ? true : false;        
        // Simplified form
        _job.partTwoFinished = _job.partOneFinished;
    }
    void PrintStatus()
    {
        string Status = _job.partOneFinished && _job.partTwoFinished
                        ? "The process is completed successfully."
                        : "Process is incomplete.";
        WriteLine(Status);
    }
    public void Execute()
    {
        // This calling sequence is OK
        Initiate();
        ExecutePartOne();
        ExecutePartTwo();
        PrintStatus();

        //// This calling sequence will cause a run-time exception.
        //ExecutePartOne();
        //Initiate();
        //ExecutePartTwo();
        //PrintStatus();

        //// This calling sequence will cause a run-time exception.
        //PrintStatus();
        //ExecutePartOne();
        //Initiate();
        //ExecutePartTwo();

    }
}


