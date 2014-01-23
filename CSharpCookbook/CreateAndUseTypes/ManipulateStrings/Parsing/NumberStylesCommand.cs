using System;
using System.Globalization;
using System.Threading;
using CSharpCookbook.BaseCommands;

namespace CSharpCookbook.CreateAndUseTypes.ManipulateStrings.Parsing
{
    public class NumberStylesCommand : DemoCommand
    {
        public NumberStylesCommand()
        {
            AddResource("Parsing with format providers", "C# In A Nutshell, Location 10191");
        }

        public override string Description
        {
            get { return "Number Styles"; }
        }

        public override void ExecuteDemo()
        {
            Console.WriteLine("Parentheses with integers represent a negative number");
            var userInput = "(2)";            
            Console.WriteLine("Parse: {0}", userInput);
            int result;
            var withoutNumberStyle = int.TryParse(userInput, out result);
            Console.WriteLine("Without NumberStyle: {0}", withoutNumberStyle);
            var withNumberStyle = int.TryParse(userInput, NumberStyles.AllowParentheses, Thread.CurrentThread.CurrentCulture, out result);
            Console.WriteLine("With NumberStyle: {0} - {1}", withNumberStyle, result);
            Console.WriteLine();

            userInput = "$1.23";
            Console.WriteLine("Parse: {0}", userInput);
            decimal currency;
            var withCurrencyStyle = decimal.TryParse(userInput, NumberStyles.Currency, Thread.CurrentThread.CurrentCulture, out currency);
            Console.WriteLine("With Currency NumberStyle: {0} - {1}", withCurrencyStyle, currency);
        }
    }
}
