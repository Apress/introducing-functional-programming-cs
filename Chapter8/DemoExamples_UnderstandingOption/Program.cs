using LanguageExt;
using static System.Console;

WriteLine("Understanding the Option type");
WriteLine("Example 1, 2 and 3\n");

// For Example 1
//Option<int> seven = Option<int>.Some(7);
//Option<string> hello = Option<string>.Some("Hello reader!");
//Option<int> empty = Option<int>.None;


//// For Example 2

//var seven = Option<int>.Some(7);
//var hello = Option<string>.Some("Hello reader!");
//var empty = Option<int>.None;

// For Example 3

Option<int> seven = 7;
Option<string> hello = "Hello reader!";
var empty = Option<int>.None;

Test3(seven);
Test3(hello);
Test3(empty);

// Using a generic method
static void Test3<T>(Option<T> val)
{
    val.Match
      (
      Some: x => WriteLine($"Received: {x}"),
      None: () => WriteLine($"Did not receive any value.")
      );
}


WriteLine("\nExample 4");
static Option<int> Test4()
{
    int random = new Random().Next(2);
    return random > 0 ? random : Option<int>.None;
}

Test4().Match
(
 Some: x => WriteLine($"Received the positive number: {x}"),
 None: () => WriteLine($"Did not receive any value.")
);

//// You can use the fluent syntax too
//Test4()
//    .Some(x => WriteLine($"Received the positive number: {x}"))
//    .None(() => WriteLine($"Did not receive any value."));


WriteLine("\nExample 5");

//Test5("hello")
//    .Some(x => WriteLine($"Entered: {x}"))
//    .None(() => WriteLine($"Got a null value."));

// Comparing  Option<string> with OptionUnsafe<string>

Test5(null)
    .Some(x => WriteLine($"Received: {x}"))
    .None(() => WriteLine($"Got a null value."));

//static Option<string> Test5(string? input)
//{
//    return input is not null ? input : null;
//}

// OUTPUT: Got a null value. (if Option<string> is the return type of Test5
static OptionUnsafe<string> Test5(string? input)
{
    return input is not null ? input : null;
}
// OUTPUT: Received: (if OptionUnsafe<string> is the return type of Test5

WriteLine("\nExample 6");
Option<int> six = 6;
WriteLine(six.Case);