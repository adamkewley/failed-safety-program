﻿using System.Windows.Input;

namespace SafetyProgram.Core.Commands.ICommands
{
    /// <summary>
    /// Defines an interface for commands that act on the document.
    /// </summary>
    public interface IDocumentICommands
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