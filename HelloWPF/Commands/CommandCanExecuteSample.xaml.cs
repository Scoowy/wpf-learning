using System.Windows;
using System.Windows.Input;

namespace HelloWPF.Commands;

public partial class CommandCanExecuteSample : Window
{
    public CommandCanExecuteSample()
    {
        InitializeComponent();
    }

    private void CutCommand_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = TxtEditor != null && TxtEditor.SelectionLength > 0;
    }

    private void CutCommand_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        TxtEditor.Cut();
    }

    private void PasteCommand_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = Clipboard.ContainsText();
    }

    private void PasteCommand_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        TxtEditor.Paste();
    }
}