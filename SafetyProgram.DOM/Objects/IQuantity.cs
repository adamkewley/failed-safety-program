﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafetyProgram.DOM.Objects
{
    /// <summary>
    /// Defines an interface for describing quantities. Previously, these were held as separate fields on the chemical class.
    /// </summary>
    public interface IQuantity
    {
        /// <summary>
        /// Get the value associated with this IQuantity
        /// </summary>
        /// <example>100</example>
        decimal Value { get; set; }

        /// <summary>
        /// Get or Set the units associated with this IQuantity
        /// </summary>
        /// <example>mgs</example>
        string Unit { get; set; }
    }
}
