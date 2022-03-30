using System.Windows;
using System.Windows.Input;

namespace HelloWPF.Commands;

public partial class CustomCommandSample : Window
{
    public CustomCommandSample()
    {
        InitializeComponent();
    }

    private void ExitCommand_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }

    private void ExitCommand_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}

public static class CustomCommands
{
    public static readonly RoutedUICommand Exit = new(
        "Exit",
        "Exit",
        typeof(CustomCommands),
        new InputGestureCollection
        {
            new KeyGesture(Key.F4, ModifierKeys.Alt)
        }
    );
}