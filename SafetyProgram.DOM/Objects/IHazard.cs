﻿using System;
using SafetyProgram.Base;

namespace SafetyProgram.DOM.Objects
{
    /// <summary>
    /// Defines the interface for a hazard object. Classes that implement this hold a collection of related COSHH details.
    /// </summary>
    public interface IHazard : IDocObj
    {
        /// <summary>
        /// Gets or Sets the Signal Word associated with this hazard. These phrases serve the same purpose as Risk Phrases.
        /// </summary>
        /// <example>H315</example>
        string SignalWord { get; set; }

        /// <summary>
        /// Gets or Sets the R-Phrase associated with this hazard. These phrases serve the same purpose as Hazard Statements (signalwords)
        /// </summary>
        /// <example>R36</example>
        string RPhrase { get; set; }

        /// <summary>
        /// Gets or Sets the Warning string associated with this hazard.
        /// </summary>
        /// <example>Causes Skin irritation.</example>
        string Warning { get; set; }

        /// <summary>
        /// Occurs when the Hazard string changes.
        /// </summary>
        event EventHandler<GenericPropertyChangedEventArg<string>> WarningChanged;
    }
}
