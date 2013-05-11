﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using SafetyProgram.Base.Interfaces;

namespace SafetyProgram.ModelObjects
{
    public interface IChemicalModelObject :
        INotifyPropertyChanged, 
        ICopyPasteable, 
        IDeepCloneable<IChemicalModelObject>, 
        IDataErrorInfo
    {
        string Name { get; set; }
        ObservableCollection<IHazardModelObject> Hazards { get; }
    }
}
