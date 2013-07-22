﻿namespace SafetyProgram.Models.Validation
{
    /// <summary>
    /// Define an invalid field error message. When invalid data/state is found with a validator 
    /// this provides a useful way of pertubating errors to the relevant UI elements etc.
    /// </summary>
    public interface IInvalidDataError
    {
        /// <summary>
        /// The invalidated field.
        /// </summary>
        object Field { get; }

        /// <summary>
        /// The name of the invalidated field.
        /// </summary>
        string FieldName { get; }

        /// <summary>
        /// The error message generated by the validator.
        /// </summary>
        string ErrorMessage { get; }
    }
}
