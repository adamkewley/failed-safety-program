﻿namespace SafetyProgram.Models
{
    /// <summary>
    /// Defines an interface for an IDocObj. An object that is usually contained in a document.
    /// </summary>
    /// <example>A Chemical Table.</example>
    public interface IDocumentObject
    {
        /// <summary>
        /// Get the unique identifier associated with this IDocObj.
        /// </summary>
        string Identifier { get; }
    }
}