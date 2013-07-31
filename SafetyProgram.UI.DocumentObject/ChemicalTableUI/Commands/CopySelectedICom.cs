﻿using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using SafetyProgram.Base;
using SafetyProgram.Base.Interfaces;
using SafetyProgram.Core.Models;

namespace SafetyProgram.UI.DocumentObject.ChemicalTableUI
{
    internal sealed class CopySelectedICom : ICommand
    {
        private readonly ObservableCollection<ICoshhChemical> selectedChemicals;

        public CopySelectedICom(ObservableCollection<ICoshhChemical> selectedChemicals)
        {
            Helpers.NullCheck(selectedChemicals);

            this.selectedChemicals = selectedChemicals;

            this.selectedChemicals.CollectionChanged += (sender, args) => CanExecuteChanged.Raise(this);     
        }

        /// <summary>
        /// Can only execute if there is currently a selection in the ChemicalTable to copy.
        /// </summary>
        /// <param name="parameter">Unused paramater</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return (selectedChemicals.Count) == 0 ? false : true;
        }

        /// <summary>
        /// Copies the selected CoshhChemicalModel(s) to the clipboard.
        /// </summary>
        /// <param name="parameter">Unused paramater.</param>
        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                try
                {
                    //selectedChemicals.TryCopy();
                }
                catch (COMException)
                {
                    MessageBox.Show("Can't Access the Clipboard!");
                    throw;
                }
            }                
        }

        public event System.EventHandler CanExecuteChanged;
    }
}
