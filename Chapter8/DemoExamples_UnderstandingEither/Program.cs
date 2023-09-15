using LanguageExt;
using static System.Console;

WriteLine("Example 1");
WriteLine("\nTesting Test1(-2, 7)");
Either<string, int> temp = Test1(-2, 7);
PrintResult(temp);
WriteLine(temp.IsLeft);// True
WriteLine(temp.IsRight);// False

WriteLine("\nExample 2");
WriteLine("Testing Test1(1,0)");
temp = Test1(1, 0);
PrintResult(temp);
WriteLine(temp.IsLeft);// True
WriteLine(temp.IsRight);// False


WriteLine("\nExample 3");
WriteLine("Testing Test1(7, 101)");
temp = Test1(7, 101);
PrintResult(temp);
WriteLine(temp.IsLeft);// True
WriteLine(temp.IsRight);// False

WriteLine("\nExample 4");
WriteLine("Testing Test1(6, 9)");
temp = Test1(6, 9);
PrintResult(temp);
WriteLine(temp.IsLeft);// False
WriteLine(temp.IsRight);// True

WriteLine("\nExample 5");
WriteLine("\nTesting Either with Test2 method");

Test2("Hello");
Test2(5);
//Test2(12.3);// Compile-time error CS1503

WriteLine("\nExample 6");
WriteLine("\nCreating an either with the left state");
// Creating an Either in the Left state
temp = Either<string, int>.Left("This is an error");
WriteLine(temp);
PrintResult(temp);

WriteLine("\nExample 7");
WriteLine("\nCreating an either with the right state");
// Creating an Either in the right state
temp = Either<string, int>.Right(123);
WriteLine(temp);
PrintResult(temp);

void PrintResult(Either<string,int> either)
{
    either.Match
    (
      Left: WriteLine,
      Right: WriteLine
    );
}

static Either<string, int> Test1(int a, int b)
{

    if (a < 0) return $"Error: the first argument {a} is negative";
    if (b == 0) return $"Error: The second argument is {b}";
    if (b > 100) return $"Error: {b} exceeds 100";
    // Everything is OK; returning the sum
    return a + b;
}
static void Test2(Either<string, int> val)
{
  val.Match
   (
    Right: x => WriteLine($"Correct value: {x}"),
    Left: x => WriteLine($"Incorrect value: '{x}'")
   );
}