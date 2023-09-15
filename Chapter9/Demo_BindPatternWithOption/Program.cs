using LanguageExt;
using static System.Console;
using static FunctionalCsharp.Calculator;
using static FunctionalCsharp.IO;

var input = GetUserInput();
Validate(input);

namespace FunctionalCsharp
{
    public static class Calculator
    {
        /// <summary>
        /// It validates the user's input
        /// </summary>
        public static Option<int> ParseInput(string input)
        {
            bool flag = int.TryParse(input, out int initialNumber);
            return !flag
                 ? Option<int>.None
                 : initialNumber;
        }

        /// <summary>
        /// It checks whether the integer is positive
        /// </summary>
        public static Option<int> CheckNonNegativity(int input)
        {
            return input < 0
                 ? Option<int>.None
                 : input;
        }
       

        //Bind:(C<T>,T->C<R>)->C<R>
        public static Option<int> BindWith(
            this Option<int> container,
            Func<int, Option<int>> f)
        {
            return container.Match
             (
                Some: x => f(x),
                None: () => Option<int>.None
             );
        }

        // Generic Version
        public static Option<R> GenericBindWith<T, R>(
           this Option<T> container,
           Func<T, Option<R>> f)
        {
            return container.Match
             (
                Some: x => f(x),
                None: () => Option<R>.None
             );
        }

    }
    public static class IO
    {
        public static string? GetUserInput()
        {
            WriteLine("Enter an integer:");
            string? input = ReadLine();
            return input;
        }
        public static void Validate(string input)
        {
            // Using custom bind function: BindWith
            ParseInput(input)
             .BindWith(CheckNonNegativity)
             .Match(
              Some: x => WriteLine($"Great.Entered a valid number: {x}"),
              None: () => WriteLine($"You did not enter a positive (or, valid) number.")
             );

            // Using custom bind function(generic version): GenericBindWith
            ParseInput(input)
             .GenericBindWith(CheckNonNegativity)
             .Match(
              Some: x => WriteLine($"Great.Entered a valid number: {x}"),
              None: () => WriteLine($"You did not entered a positive (or, valid) number.")
             );

            // Using inbuilt Bind from LanguageExt
            ParseInput(input)
             .Bind(CheckNonNegativity)
             .Match(
              Some: x => WriteLine($"Great.Entered a valid number: {x}"),
              None: () => WriteLine($"You did not entered a positive (or, valid) number.")
            );
        }      
    }
}

