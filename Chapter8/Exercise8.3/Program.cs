using LanguageExt;
using static System.Console;


//WriteLine("Exercise 8.3");


Welcome("Kate").Match(
    Some: WriteLine,
    None: () => WriteLine($"Hi Guest! Who are you?")
    );

Welcome(null).Match(
    Some: WriteLine,
    None: () => WriteLine($"Hi Guest! Who are you?")
    );


static Option<string> Welcome(string? input)
{
    return input == null
        ? Option<string>.None
        : $"Hello, {input}! How are you?";
}




