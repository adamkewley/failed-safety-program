﻿using System;
using System.Windows.Input;
using SafetyProgram.Base;
using SafetyProgram.Base.Interfaces;

namespace SafetyProgram.Document.Commands
{
    public sealed class DeleteIDocObjectICom : ICommand
    {
        private readonly IDocument data;

        /// <summary>
        /// Construct an ICommand that deletes the currently selected item in the CoshhDocument.
        /// </summary>
        /// <param name="document">CoshhDocument from which selected items will be deleted.</param>
        public DeleteIDocObjectICom(IDocument document)
        {
            this.data = document;
            //Monitor changes in the CoshhDocument's selection (can't delete if there isn't a selection).
            document.Body.SelectionChanged += (IDocumentObject docObject) => CanExecuteChanged.Raise(this);
        }        

        /// <summary>
        /// Can only execute if there is currently something selected
        /// </summary>
        /// <param name="parameter">Unused paramater</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return data.Body.Selection == null ? false : true;
        }

        /// <summary>
        /// Deletes the currently selected DocObject from the CoshhDocument
        /// </summary>
        /// <param name="parameter">Unused paramater</param>
        /// <exception cref="NotSupportedException">Thrown if Execute is called but CanExecute == false</exception>
        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                data.Body.Items.Remove(data.Body.Selection);
                data.Body.DeSelectAll();
            }
            else throw new NotSupportedException("Call to execute made when it cant execute (CanExecute() == false)");            
        }

        public event EventHandler CanExecuteChanged;
    }
}
