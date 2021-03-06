﻿using CSharpCookbook.BaseCommands;
using CSharpCookbook.CreateAndUseTypes.ClassHierarchy;
using CSharpCookbook.CreateAndUseTypes.ConsumeTypes;
using CSharpCookbook.CreateAndUseTypes.CreateTypes;
using CSharpCookbook.CreateAndUseTypes.Encapsulation;
using CSharpCookbook.CreateAndUseTypes.ManipulateDates;
using CSharpCookbook.CreateAndUseTypes.ManipulateStrings;
using CSharpCookbook.CreateAndUseTypes.ReflectionAndMetadata;

namespace CSharpCookbook.CreateAndUseTypes
{
    public class CreateAndUseTypesCommand : DisplayCommand
    {
        public override string Description { get { return "Create And Use Types"; } }

        public CreateAndUseTypesCommand()
        {
            AddCommand(new CreateTypesCommand());
            AddCommand(new ConsumeTypesCommand());
            AddCommand(new EncapsulationCommand());
            AddCommand(new ClassHierarchyCommand());
            AddCommand(new ReflectionCommand());
            AddCommand(new ManipulateStringsCommand());
            AddCommand(new ManipulateDatesCommand());
        }
    }
}
