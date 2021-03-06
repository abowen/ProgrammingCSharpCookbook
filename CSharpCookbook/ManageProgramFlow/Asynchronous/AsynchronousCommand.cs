﻿using CSharpCookbook.BaseCommands;
using CSharpCookbook.ManageProgramFlow.Asynchronous.AsyncAwait;
using CSharpCookbook.ManageProgramFlow.Asynchronous.ConcurrentCollections;
using CSharpCookbook.ManageProgramFlow.Asynchronous.ParallelFor;
using CSharpCookbook.ManageProgramFlow.Asynchronous.PLINQ;
using CSharpCookbook.ManageProgramFlow.Asynchronous.Tasks;
using CSharpCookbook.ManageProgramFlow.Asynchronous.Threads;

namespace CSharpCookbook.ManageProgramFlow.Asynchronous
{
    public class AsynchronousCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "Asynchronous"; }
        }

        public AsynchronousCommand()
        {
            AddCommand(new ParallelForCommand());
            AddCommand(new ParallelForBreakCommand());
            AddCommand(new ParallelForStopCommand());
            AddCommand(new ParallelForCancelCommand());
            AddCommand(new AsParallelCommand());
            AddCommand(new AsOrderedCommand());
            AddCommand(new ForAllCommand());
            AddCommand(new StartNewCommand());
            AddCommand(new ContinueWithCommand());
            AddCommand(new WaitCommand());
            AddCommand(new ThreadCommand());
            AddCommand(new ThreadPoolCommand());
            AddCommand(new BackgroundWorkerCommand());
            AddCommand(new AsyncAwaitCommand());
            AddCommand(new ConcurrentStackCommand());
        }
    }
}