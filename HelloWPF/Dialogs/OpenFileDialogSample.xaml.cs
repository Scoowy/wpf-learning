using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace HelloWPF.Dialogs;

public partial class OpenFileDialogSample : Window
{
    public OpenFileDialogSample()
    {
        InitializeComponent();
    }

    private void BtnOpenFile_OnClick(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter =
            "Text files (*.txt)|*.txt|Web files (*.html;*.js;*.css)|*.html;*.js;*.css|All files (*.*)|*.*";

        // Directorio por defecto establecido por nosotros
        // openFileDialog.InitialDirectory = @"c:\tools\";
        
        // Directorios genericos de windows (escritorio, usuarios, documentos, etc.)
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        
        if (openFileDialog.ShowDialog() == true) TxtEditor.Text = File.ReadAllText(openFileDialog.FileName);
    }
}