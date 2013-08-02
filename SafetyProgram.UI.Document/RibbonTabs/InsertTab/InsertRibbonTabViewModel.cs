﻿using SafetyProgram.Base;
using SafetyProgram.Core.Commands;

namespace SafetyProgram.Document.Ribbons
{
    /// <summary>
    /// Defines a standard implementation of an IInsertRibbonTabViewModel.
    /// </summary>
    public sealed class InsertRibbonTabViewModel : IInsertRibbonTabViewModel
    {
        /// <summary>
        /// Construct an instance of a viewmodel for an insert ribbon.
        /// </summary>
        /// <param name="commands">A set of commands that act on the document that items will be inserted into.</param>
        public InsertRibbonTabViewModel(IDocumentICommands commands)
        {
            Helpers.NullCheck(commands);

            this.commands = commands;
        }

        private readonly IDocumentICommands commands;

        /// <summary>
        /// Get a group of commands that act on the current document.
        /// </summary>
        public IDocumentICommands Commands
        {
            get { return commands; }
        }
    }
}