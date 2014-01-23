using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace CSharpCookbook.BaseCommands
{
    public abstract class DemoCommand : IMyCommand
    {
        public abstract string Description { get; }

        public abstract void ExecuteDemo();

        private readonly List<ExternalResource> _resources = new List<ExternalResource>();

        public void AddResource(string title, string location)
        {
            _resources.Add(new ExternalResource(title, location));
        }

        public void RepeatMethod(Action method, int amount = 100)
        {
            var stopWatch = Stopwatch.StartNew();
            for (var i = 0; i < amount; i++)
            {
                method.Invoke();
            }
            stopWatch.Stop();
            Console.WriteLine("{0} : {1}ms", method.GetMethodInfo().Name, stopWatch.ElapsedMilliseconds);
            Console.WriteLine();
        }

        public void CultureMethod(Action method, CultureInfo culture)
        {
            Console.WriteLine("{0} {1}", method.GetMethodInfo(), culture);
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            method.Invoke();            
            Thread.CurrentThread.CurrentCulture = currentCulture;
            Console.WriteLine();
        }

        public void ExecuteCommand()
        {
            while (true)
            {
                Console.WriteLine("************");
                Console.WriteLine(Description);
                Console.WriteLine("************");

                Console.WriteLine("0 : Back");
                Console.WriteLine("1 : Demo");
                Console.WriteLine("2 : Resources");

                var key = Console.ReadLine();
                var value = -1;
                int.TryParse(key, out value);
                if (value == 1)
                {
                    Console.WriteLine("-- {0} Entry --", Description);
                    ExecuteDemo();
                    Console.WriteLine("-- {0} Exit -- ", Description);
                    Console.WriteLine();
                }
                else if (value == 2)
                {
                    if (!_resources.Any())
                    {
                        Console.WriteLine("No Resources Found");
                    }
                    else
                    {
                        Console.WriteLine();
                        _resources.ForEach(Console.WriteLine);
                        Console.WriteLine();
                    }                                        
                }
                else if (value == 0)
                {
                    break;
                }
                else if (value == -1)
                {
                    Console.WriteLine("Invalid input {0}", key);
                }
            }
        }
    }
}
