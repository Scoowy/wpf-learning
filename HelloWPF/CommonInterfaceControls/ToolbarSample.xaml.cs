using System.Windows;
using System.Windows.Input;

namespace HelloWPF.CommonInterfaceControls;

public partial class ToolbarSample : Window
{
    public ToolbarSample()
    {
        InitializeComponent();
    }

    private void CommonCommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }
}