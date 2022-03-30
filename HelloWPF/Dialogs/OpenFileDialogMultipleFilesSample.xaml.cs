using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace HelloWPF.Dialogs;

public partial class OpenFileDialogMultipleFilesSample : Window
{
    public OpenFileDialogMultipleFilesSample()
    {
        InitializeComponent();
    }

    private void BtnOpenFile_OnClick(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog
        {
            Multiselect = true,
            Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };

        if (openFileDialog.ShowDialog() != true) return;

        foreach (var fileName in openFileDialog.FileNames)
        {
            LblFiles.Items.Add(Path.GetFileName(fileName));
        }
    }
}