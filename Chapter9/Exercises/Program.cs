using LanguageExt;
using static System.Console;

WriteLine("Exercises");

// Exercise 9.1
var option = Option<int>.Some(15);
var result = option
    .Bind<int>(x => x * 3)
    .Bind<int>(y => y + 10);
WriteLine(result); // Some(55)


// Exercise 9.2

//var result2 = option
//    .Bind<int>(x => x + 3)
//    .Bind<int, int>(y => x * y); // Error
//WriteLine(result2); 


// Exercise 9.3
Func<int, Option<int>> add3 = x => x + 3;
Func<int, int, Option<int>> multiply = (x, y) => x * y;

// Using local functions
//Option<int> add3(int x) => x + 3;
//Option<int> multiply(int x, int y) => x * y;


var result3 = option
    .Bind(x => add3(x)
      .Bind(y => multiply(x, y)));
WriteLine(result3); // Some(18*15)


// Exercise 9.4
Either<Exception, string> either1 = "10";

Func<string, Either<Exception, int>> add4 = x => int.Parse(x) + 4;
var result4 = either1.Bind(x => add4(x));

//Either<Exception, int> add4(string s) => int.Parse(s) + 4;
//var result4 = either1.Bind(add4);

WriteLine(result4); // Right(14)

// Exercise 9.5
Func<double, Either<string, double>> add5 = x => x + 5;
Func<double, double, Either<string, double>> divide = (x, y) => y / x + " Done";
var either2 = Either<string, double>.Right(10);
var result5 = either2
    .Bind(x => add5(x)
     .Bind(y => divide(x, y)));
WriteLine(result5); // Left(1.5 Done)

// Exercise 9.6
Func<int, Either<string, int>> add6 = x => x + 6;
Func<int, int, Either<string, int>> multiplyNumbers = (x, y) => x * y;
var either3 = Either<string, int>.Right(10);
var result6 = either3
    .Bind(x => add6(x)
     .Bind(y => multiplyNumbers(x, y)));
WriteLine(result6); // Right(160)
