﻿using System;
using System.Collections.ObjectModel;
using SafetyProgram.Base;

namespace SafetyProgram.Models
{
    /// <summary>
    /// Defines an implementation for IChemical. A class that holds chemical information.
    /// </summary>
    public sealed class Chemical : IChemical
    {
        /// <summary>
        /// Create a new instance of Chemical. An object that holds general chemical information.
        /// </summary>
        /// <param name="name">The name of the Chemical.</param>
        /// <param name="hazards">The Hazards associated with the Chemical.</param>
        public Chemical(string name, ObservableCollection<IHazard> hazards)
        {
            Helpers.NullCheck(name, hazards);

            this.name = name;
            this.hazards = hazards;
        }

        private string name;

        /// <summary>
        /// Get or Set the name of the Chemical.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NameChanged.Raise(this, value);
            }
        }

        /// <summary>
        /// Occurs when the name of the Chemical changes.
        /// </summary>
        public event EventHandler<GenericPropertyChangedEventArg<string>> NameChanged;

        private readonly ObservableCollection<IHazard> hazards;
        
        /// <summary>
        /// Gets the hazards associated with this chemical.
        /// </summary>
        public ObservableCollection<IHazard> Hazards
        {
            get { return hazards; }
        }

        /// <summary>
        /// Get the unique identifier for this type of object.
        /// </summary>
        /// <example>ChemicalObject</example>
        public string Identifier
        {
            get { return Identifiers.CHEMICAL_IDENTIFIER; }
        }
    }
}