using LanguageExt;
using System;
using static System.Console;

Func<int, Option<int>> f = x => x * 2;
Func<int, Option<double>> g = x => x + 5.5;

var option = Option<int>.Some(15);

//  Testing Left Identity:  Return(x).Bind(f) == f(x)  

var result1 = option.Bind(f);
WriteLine(result1);  // Some(30)
var result2 = f(15);
WriteLine(result2);// Some(30)

//  Testing Right Identity:  m.Bind(Return)= m 
var result3 = option.Bind(Option<int>.Some);
WriteLine(result3);
var result4 = option;
WriteLine(result4);

//  Testing associativity: m.Bind(f).Bind(g)=m.Bind(x=>f(x).Bind(g))
var result5 = option.Bind(f).Bind(g);
WriteLine(result5);
var result6 = option.Bind(x => f(x).Bind(g));
WriteLine(result6);













