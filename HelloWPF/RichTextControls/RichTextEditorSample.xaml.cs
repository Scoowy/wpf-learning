using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;

namespace HelloWPF.RichTextControls;

public partial class RichTextEditorSample : Window {
    public RichTextEditorSample() {
        InitializeComponent();

        CmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
        CmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
    }

    private void Open_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
        var dlg = new OpenFileDialog {
            Filter = "Rich Text Format (*rtf)|*.rtf|All files (*.*)|*.*"
        };

        if (dlg.ShowDialog() != true) return;

        var fileStream = new FileStream(dlg.FileName, FileMode.Open);
        var range = new TextRange(RtbEditor.Document.ContentStart, RtbEditor.Document.ContentEnd);
        range.Load(fileStream, DataFormats.Rtf);
    }

    private void Save_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
        var dlg = new SaveFileDialog {
            Filter = "Rich Text Format (*rtf)|*.rtf|All files (*.*)|*.*"
        };

        if (dlg.ShowDialog() != true) return;

        var fileStream = new FileStream(dlg.FileName, FileMode.Create);
        var range = new TextRange(RtbEditor.Document.ContentStart, RtbEditor.Document.ContentEnd);
        range.Save(fileStream, DataFormats.Rtf);
    }

    private void CmbFontFamily_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (CmbFontFamily.SelectedItem != null) {
            RtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, CmbFontFamily.SelectedItem);
        }
    }

    private void CmbFontSize_OnTextChanged(object sender, TextChangedEventArgs e) {
        try {
            RtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, CmbFontSize.Text);
        }
        catch (Exception exception) {
            Console.WriteLine(exception);
        }
    }

    private void RtbEditor_OnSelectionChanged(object sender, RoutedEventArgs e) {
        var weightProp = RtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
        var styleProp = RtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
        var decorationProp = RtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);

        var familyProp = RtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
        var sizeProp = RtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);

        BtnBold.IsChecked = weightProp != DependencyProperty.UnsetValue && weightProp.Equals(FontWeights.Bold);
        BtnItalic.IsChecked = styleProp != DependencyProperty.UnsetValue && styleProp.Equals(FontStyles.Italic);
        BtnUnderline.IsChecked =
            styleProp != DependencyProperty.UnsetValue && styleProp.Equals(TextDecorations.Underline);

        CmbFontFamily.SelectedItem = familyProp;
        CmbFontSize.Text = sizeProp.ToString();
    }
}