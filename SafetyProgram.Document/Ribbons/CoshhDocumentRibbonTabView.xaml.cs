﻿using Fluent;

namespace SafetyProgram.Document.Ribbons
{
    /// <summary>
    /// Interaction logic for CoshhDocumentRibbonTabView.xaml
    /// </summary>
    internal sealed partial class CoshhDocumentRibbonTabView : RibbonTabItem
    {
        public CoshhDocumentRibbonTabView(ICoshhDocumentRibbonTabViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }
    }
}
