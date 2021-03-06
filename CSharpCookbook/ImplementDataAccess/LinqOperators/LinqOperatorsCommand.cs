﻿using CSharpCookbook.BaseCommands;
using CSharpCookbook.ImplementDataAccess.Linq.Operators;
using CSharpCookbook.ImplementDataAccess.LinqOperators.Grouping;
using CSharpCookbook.ImplementDataAccess.LinqOperators.Joining;
using CSharpCookbook.ImplementDataAccess.LinqOperators.Ordering;
using CSharpCookbook.ImplementDataAccess.LinqOperators.Projecting;
using CSharpCookbook.ImplementDataAccess.LinqOperators.Scalar;

namespace CSharpCookbook.ImplementDataAccess.LinqOperators
{
    public class LinqOperatorsCommand : DisplayCommand
    {
        public override string Description
        {
            get { return "LINQ Operators"; }
        }

        public LinqOperatorsCommand()
        {
            AddCommand(new WhereCommand());
            AddCommand(new GroupByCommand());
            AddCommand(new JoinCommand());
            AddCommand(new OrderByCommand());
            AddCommand(new SelectCommand());
            AddCommand(new CountCommand());
            AddCommand(new AggregateCommand());
            AddCommand(new AverageCommand());
        }
    }
}