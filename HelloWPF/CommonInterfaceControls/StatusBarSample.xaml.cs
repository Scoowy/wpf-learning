using System.Windows;

namespace HelloWPF.CommonInterfaceControls;

public partial class StatusBarSample : Window
{
    public StatusBarSample()
    {
        InitializeComponent();
    }

    private void TxtEditor_OnSelectionChanged(object sender, RoutedEventArgs e)
    {
        var row = TxtEditor.GetLineIndexFromCharacterIndex(TxtEditor.CaretIndex);
        var col = TxtEditor.CaretIndex - TxtEditor.GetCharacterIndexFromLineIndex(row);
        LblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
    }
}