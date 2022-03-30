using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HelloWPF.DataBinding;

public partial class ConverterSample : Window
{
    public ConverterSample()
    {
        InitializeComponent();
    }
}

public class YesNoToBooleanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        switch (value.ToString()!.ToLower())
        {
            case "yes":
            case "oui":
                return true;
            case "no":
            case "non":
                return false;
        }

        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not bool b) return "no";
        return b ? "yes" : "no";
    }
}