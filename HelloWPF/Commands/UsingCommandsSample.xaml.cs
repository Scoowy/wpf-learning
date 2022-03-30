using System.Windows;
using System.Windows.Input;

namespace HelloWPF.Commands;

public partial class UsingCommandsSample : Window
{
    public UsingCommandsSample()
    {
        InitializeComponent();
    }

    private void NewCommand_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        MessageBox.Show("The New Command was invoked");
    }

    private void NewCommand_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }
}