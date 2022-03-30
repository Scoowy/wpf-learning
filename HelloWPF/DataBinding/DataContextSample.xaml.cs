using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HelloWPF.DataBinding;

public partial class DataContextSample : Window
{
    public DataContextSample()
    {
        InitializeComponent();
        this.DataContext = this;
    }

    private void BtnUpdateSource_OnClick(object sender, RoutedEventArgs e)
    {
        var binding = TxtWindowTitle.GetBindingExpression(TextBox.TextProperty);
        binding!.UpdateSource();
    }
}