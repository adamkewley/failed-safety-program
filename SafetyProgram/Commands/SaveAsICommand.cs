﻿using System;
using System.Windows;

namespace SafetyProgram.Commands
{
    public class SaveAsICommand : CoshhWindowICommand
    {
        /// <summary>
        /// Constructs a new ICommand that allows 'SaveAs' of the CoshhWindow's document using the CoshhWindow's service.
        /// </summary>
        /// <param name="window">Window which houses the document to be 'SavedAs'</param>
        public SaveAsICommand(CoshhWindow window)
            : base(window)
        {
            //Monitor if the CoshhWindow's service has changed (CanSaveAs() can change).
            window.ServiceChanged += (service) => RaiseCanExecuteChanged();

            //Monitor if the CoshhWindow's CoshhDocument has changed (can't save a closed (null) document).
            window.DocumentChanged += (document) => RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Can execute if there is a CoshhDocument open to save and the CoshhWindow's service allows saving as.
        /// </summary>
        /// <param name="parameter">Unused paramater</param>
        /// <returns></returns>
        public override bool CanExecute(object parameter)
        {
            return (window.Document != null && window.Service.CanSaveAs()) ? true : false;
        }

        /// <summary>
        /// Attempts to save the CoshhWindow's CoshhDocument as.
        /// </summary>
        /// <param name="parameter">Unused paramater</param>
        /// <exception cref="NotSupportedException">Thrown if Execute is called when CanExecute is false</exception>
        public override void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                try
                {
                    window.Service.SaveAs(window.Document);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Error: You do not have sufficient permissions to save to this location.");
                }
                catch (ArgumentException)
                {
                    //Saving As can cancelled for some reason, discontinue execution.
                    return;
                }
            }
            else throw new NotSupportedException("Call to execute made when it cant execute (CanExecute() == false)"); 
        }
    }
}