﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoHub.Helpers
{
    public class GridView: Windows.UI.Xaml.Controls.GridView
    {
        protected override void PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject element, object item)
        {
            try
            {
                dynamic _Item = item;
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.ColumnSpanProperty, _Item.ColSpan);
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.RowSpanProperty, _Item.RowSpan);
            }
            catch
            {
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.ColumnSpanProperty, 1);
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.RowSpanProperty, 1);
            }
            finally
            {
                base.PrepareContainerForItemOverride(element, item);
            }
        }
    }
}
