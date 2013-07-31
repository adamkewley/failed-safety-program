﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using SafetyProgram.Base;
using SafetyProgram.Base.GenericCommands;
using SafetyProgram.Base.Interfaces;
using SafetyProgram.Core.Models;

namespace SafetyProgram.UI.DocumentObject.ChemicalTableUI
{
    internal sealed class InsertChemicalICom : ICommand
    {
        private readonly ICollection<ICoshhChemical> chemicals;
        private readonly ICommandInvoker commandInvoker;

        public InsertChemicalICom(ICollection<ICoshhChemical> chemicals, 
            ICommandInvoker commandInvoker)
        {
            Helpers.NullCheck(chemicals, commandInvoker);

            this.chemicals = chemicals;
            this.commandInvoker = commandInvoker;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                //Repository will contain ChemicalModels; however, we need a CoshhChemicalModel (extended form)
                //var chemicalToAdd = ModelObjectsPrototypes.CoshhChemicalObject(0M, "", (IChemicalModelObject)parameter);
                //var command = new AddItemInvokedICom<ICoshhChemicalObject>(chemicals, chemicalToAdd);
                //commandInvoker.InvokeCommand(command);
            }
        }
    }
}
