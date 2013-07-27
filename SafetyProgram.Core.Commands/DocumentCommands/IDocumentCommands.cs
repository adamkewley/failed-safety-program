﻿using System.Collections.Generic;
using System.Windows.Input;
using SafetyProgram.Base.Interfaces;

namespace SafetyProgram.DocumentUi.Commands
{
    /// <summary>
    /// Defines an interface for commands that act on the document.
    /// </summary>
    public interface IDocumentICommands : ICommandsHolder
    {
        /// <summary>
        /// Get an ICommand for deleting an IDocumentObject
        /// </summary>
        ICommand DeleteIDocObject { get; }

        /// <summary>
        /// Get an ICommand for inserting a new Chemical Table.
        /// </summary>
        ICommand InsertChemicalTable { get; }
    }
}