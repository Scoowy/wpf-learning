using System;
using System.Windows;

namespace HelloWPF.Dialogs;

public partial class InputDialogSample : Window
{
    public InputDialogSample(string question, string defaultAnswer = "")
    {
        InitializeComponent();

        LblQuestion.Content = question;
        TxtAnswer.Text = defaultAnswer;
    }

    public string Answer => TxtAnswer.Text;

    private void Window_OnContentRendered(object? sender, EventArgs e)
    {
        TxtAnswer.SelectAll();
        TxtAnswer.Focus();
    }

    private void BtnDialogOk_OnClick(object sender, RoutedEventArgs e)
    {
        this.DialogResult = true;
    }
}