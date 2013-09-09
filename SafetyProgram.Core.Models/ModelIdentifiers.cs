﻿namespace SafetyProgram.Core.Models
{
    /// <summary>
    /// Defines a class that contains the unique identifiers for different IDocObj's (ChemicalTable, ApparatusTable, etc.)
    /// </summary>
    public static class ModelIdentifiers
    {
        /// <summary>
        /// Get the unique identifier for the ChemicalTable IDocObj.
        /// </summary>
        public const string CHEMICAL_TABLE_IDENTIFIER = "ChemicalTable";

        /// <summary>
        /// Gets the unique identifier associated with a chemical.
        /// </summary>
        public const string CHEMICAL_IDENTIFIER = "Chemical";

        /// <summary>
        /// Gets the unique identifier associated with a hazard.
        /// </summary>
        public const string HAZARD_IDENTIFIER = "Hazard";

        /// <summary>
        /// Gets the unique identifier associated with a CoshhChemical entry.
        /// </summary>
        public const string COSHH_CHEMICAL_IDENTIFIER = "CoshhChemical";

        public const string QUANTITY_IDENTIFIER = "Quantity";
        public const string FORMAT_IDENTIFIER = "Format";
        public const string DOCUMENT_IDENTIFIER = "Document";
        public const string APPLICATION_CONFIGURATION_IDENTIFIER = "AppConfig";
    }
}
