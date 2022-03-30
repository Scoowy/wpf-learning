using System;
using System.Windows;
using System.Windows.Documents;

namespace HelloWPF.RichTextControls;

public partial class RichTextBoxTextSelectionSample : Window {
    public RichTextBoxTextSelectionSample() {
        InitializeComponent();
    }

    private void BtnGetText_OnClick(object sender, RoutedEventArgs e) {
        var textRange = new TextRange(RtbEditor.Document.ContentStart, RtbEditor.Document.ContentEnd);
        MessageBox.Show(textRange.Text);
    }

    private void BtnSetText_OnClick(object sender, RoutedEventArgs e) {
        var textRange = new TextRange(RtbEditor.Document.ContentStart, RtbEditor.Document.ContentEnd);
        textRange.Text = "Another world, another text!";
    }

    private void BtnGetSelectedText_OnClick(object sender, RoutedEventArgs e) {
        MessageBox.Show(RtbEditor.Selection.Text);
    }

    private void BtnSetSelectedText_OnClick(object sender, RoutedEventArgs e) {
        RtbEditor.Selection.Text = "[Replaced text]";
    }

    private void RtbEditor_OnSelectionChanged(object sender, RoutedEventArgs e) {
        var tempRange = new TextRange(RtbEditor.Document.ContentStart, RtbEditor.Selection.Start);
        TxtStatus.Text = "Selection starts at character #" + tempRange.Text.Length + Environment.NewLine;
        TxtStatus.Text += "Selection is " + RtbEditor.Selection.Text.Length + " character(s) long" +
                          Environment.NewLine;
        TxtStatus.Text += "Selected text: '" + RtbEditor.Selection.Text + "'";
    }
}