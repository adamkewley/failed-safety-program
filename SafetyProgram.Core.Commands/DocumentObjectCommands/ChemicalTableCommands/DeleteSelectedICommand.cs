﻿using System;
using System.Windows.Input;
using SafetyProgram.Base;
using SafetyProgram.Core.Models;

namespace SafetyProgram.Core.Commands.DocumentObjectCommands.ChemicalTableCommands
{
    internal sealed class DeleteSelectedICommand : ICommand
    {
        public DeleteSelectedICommand(IChemicalTable chemicalTable,
            ICommandInvoker commandInvoker)
        {
            Helpers.NullCheck(chemicalTable, commandInvoker);
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}