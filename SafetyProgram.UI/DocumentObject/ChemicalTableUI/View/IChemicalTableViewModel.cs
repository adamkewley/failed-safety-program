﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using SafetyProgram.Core.Models;

namespace SafetyProgram.UI.DocumentObject.ChemicalTableUI
{
    /// <summary>
    /// Defines a ViewModel for the chemicaltable view.
    /// </summary>
    internal interface IChemicalTableViewModel : 
        INotifyPropertyChanged
    {
        /// <summary>
        /// Get or set the header of the chemicaltable.
        /// </summary>
        string Header { get; set; }

        /// <summary>
        /// Get the chemicals in the chemicaltable.
        /// </summary>
        ReadOnlyObservableCollection<ICoshhChemical> Chemicals { get; }
    }
}