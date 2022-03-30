using System;
using System.Windows;

namespace HelloWPF.Dialogs;

public partial class MessageBoxSample : Window
{
    public MessageBoxSample()
    {
        InitializeComponent();
    }

    private void BtnSimpleMessageBox_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello, world!");
    }

    private void BtnMessageBoxWithTitle_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello, world!", "My App");
    }

    private void BtnMessageBoxWithButtons_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("This MessageBox has extra options.\n\nHello, world?", "My App", MessageBoxButton.YesNoCancel);
    }

    private void BtnMessageBoxWithResponse_OnClick(object sender, RoutedEventArgs e)
    {
        var result = MessageBox.Show("Would you like to greet the world with a \"Hello, world\"?",
            "My App", MessageBoxButton.YesNoCancel);

        switch (result)
        {
            case MessageBoxResult.Yes:
                MessageBox.Show("Hello to you too!", "My App");
                break;
            case MessageBoxResult.No:
                MessageBox.Show("Oh well, too bad!", "My App");
                break;
            case MessageBoxResult.Cancel:
                MessageBox.Show("Nevermind then...", "My App");
                break;
            case MessageBoxResult.None:
            case MessageBoxResult.OK:
            default:
                MessageBox.Show("Another response", "My App");
                break;
        }
    }

    private void BtnMessageBoxWithIcon_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void BtnMessageBoxWithDefaultChoice_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello, world?", "My App", MessageBoxButton.YesNo, MessageBoxImage.Question,
            MessageBoxResult.No);
    }
}