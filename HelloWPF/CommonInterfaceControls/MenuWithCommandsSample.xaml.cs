using System.Windows;
using System.Windows.Input;

namespace HelloWPF.CommonInterfaceControls;

public partial class MenuWithCommandsSample : Window
{
    public MenuWithCommandsSample()
    {
        InitializeComponent();
    }

    private void NewCommand_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }

    private void NewCommand_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        TxtEditor.Text = "";
    }
}