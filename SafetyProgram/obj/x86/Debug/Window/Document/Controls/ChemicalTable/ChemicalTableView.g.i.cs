﻿#pragma checksum "..\..\..\..\..\..\..\Window\Document\Controls\ChemicalTable\ChemicalTableView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D0B05E844F38EA3CCC4BEF3D487FF1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.586
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SafetyProgram.Window.Document.Controls.ChemicalTable {
    
    
    /// <summary>
    /// ChemicalTableView
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ChemicalTableView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SafetyProgram;component/window/document/controls/chemicaltable/chemicaltableview" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Window\Document\Controls\ChemicalTable\ChemicalTableView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\..\..\..\Window\Document\Controls\ChemicalTable\ChemicalTableView.xaml"
            ((SafetyProgram.Window.Document.Controls.ChemicalTable.ChemicalTableView)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 69 "..\..\..\..\..\..\..\Window\Document\Controls\ChemicalTable\ChemicalTableView.xaml"
            ((System.Windows.Controls.ListView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

