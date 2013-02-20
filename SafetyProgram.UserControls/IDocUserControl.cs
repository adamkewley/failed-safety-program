﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SafetyProgram.UserControls
{
    public interface IDocUserControl : IDocInteractable
    {
        UserControl Display();

        IEnumerable<IDocDataHolder<object>> Data();
    }
}
