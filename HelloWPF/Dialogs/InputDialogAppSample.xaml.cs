using System.Windows;

namespace HelloWPF.Dialogs;

public partial class InputDialogAppSample : Window
{
    public InputDialogAppSample()
    {
        InitializeComponent();
    }

    private void BtnEnterName_OnClick(object sender, RoutedEventArgs e)
    {
        var inputDialog = new InputDialogSample("Please enter your name:", "John Doe");
        if (inputDialog.ShowDialog() == true) LblName.Text = inputDialog.Answer;
    }
}