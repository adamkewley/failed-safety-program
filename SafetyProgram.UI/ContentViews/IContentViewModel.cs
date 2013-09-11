﻿using System.ComponentModel;
using System.Windows.Controls;

namespace SafetyProgram.UI.ContentViews
{
    /// <summary>
    /// Defines a viewmodel for the main content view.
    /// </summary>
    public interface IContentViewModel :
        INotifyPropertyChanged
    {
        /// <summary>
        /// Get the content view (usually document).
        /// </summary>
        Control Content { get; }
    }
}
