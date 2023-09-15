using LanguageExt;
using static System.Console;

//Func<int, Option<int>> square = x => x * x;

//Func<int, int, Option<int>> multiply = (x, y) => x * y;

// using local functions
Option<int> square(int x) => x * x;
Option<int> multiply(int x, int y) => x * y;


var result1 = Option<int>.Some(3);  
WriteLine(result1);// Some(3)

var result2 = Option<int>.Some(3)
              .Bind(x => square(x)); 
WriteLine(result2);// Some(9)

// Passing multiple arguments
var result = Option<int>.Some(3)  // Some(3)
              .Bind(x => square(x)  // Some(9)
              .Bind(y => multiply(x, y)));   // Some(3*9)                               
WriteLine(result);// Some(27)




