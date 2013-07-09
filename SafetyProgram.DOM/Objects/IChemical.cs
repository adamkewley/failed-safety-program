﻿using System;
using System.Collections.ObjectModel;
using SafetyProgram.Base;

namespace SafetyProgram.DOM.Objects
{
    /// <summary>
    /// Defines an interface for a Chemical in the SafetyProgram. The chemical requires a name and hazards associated with it.
    /// </summary>
    public interface IChemical : IDocObj
    {
        /// <summary>
        /// Gets the name of the chemical.
        /// </summary>
        /// <example>Acetonitrile</example>
        string Name { get; set; }

        /// <summary>
        /// Occurs when the name of the chemical changes.
        /// </summary>
        event EventHandler<GenericPropertyChangedEventArg<string>> NameChanged;

        /// <summary>
        /// Gets the Hazards associated with the chemical.
        /// </summary>
        ObservableCollection<string> Hazards { get; }
    }
}
