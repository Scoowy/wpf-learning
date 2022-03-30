using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace HelloWPF.Dialogs;

public partial class SaveFileDialogSample : Window
{
    public SaveFileDialogSample()
    {
        InitializeComponent();
    }

    private void BtnSaveFile_OnClick(object sender, RoutedEventArgs e)
    {
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "Text file (*.txt)|*.txt|Python file (*.py)|*.py",
            DefaultExt = ".py",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };

        if (saveFileDialog.ShowDialog() == true)
        {
            File.WriteAllText(saveFileDialog.FileName, TxtEditor.Text);
        }
    }
}