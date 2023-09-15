using static System.Console;

WriteLine(AddFiveTo(2));
WriteLine(GetRandomNumber(2));

static int AddFiveTo(int input)
{
    return input + 5;
}
static int GetRandomNumber(int input)
{
    Random random = new();
    return random.Next(input, input + 5);
}

