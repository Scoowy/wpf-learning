using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HelloWPF.DataBinding;

public partial class DataBindingDebuggingSample : Window
{
    public DataBindingDebuggingSample()
    {
        InitializeComponent();
    }
}

public class DebugDummyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        Debugger.Break();
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        Debugger.Break();
        return value;
    }
}