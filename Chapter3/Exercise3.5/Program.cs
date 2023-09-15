using static System.Console;
WriteLine("Exercise 3.5");
Dictionary<string, int> worldCupRecords = new()
{
    {"Brazil",5 },
    {"Italy",4 },
    {"Germany",4 }    
};

FifaTitles winners = new("MaximumTitleWinners", worldCupRecords);
WriteLine($"Current count:{winners.CountriesWithNumbers.Count}");

// We cannot mutate the state directly, 

//winners.Name = "Atleast Four time winners";// Error CS0200
//winners.CountriesWithNumbers = null;// Error CS0200

// But we can mutate the state
// using the CountriesWithNumbers property
winners.CountriesWithNumbers.Add("Argentina", 3); // OK
WriteLine($"Current count:{winners.CountriesWithNumbers.Count}"); // OK


sealed class FifaTitles
{
    public string Name { get; }    
    public Dictionary<string, int> CountriesWithNumbers { get; }
    public FifaTitles(string name,Dictionary<string, int> winners)
    {
        Name = name;
        CountriesWithNumbers = winners;
    }
}