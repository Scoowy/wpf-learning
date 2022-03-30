using System.Windows;

namespace HelloWPF.RichTextControls;

public partial class FlowDocumentSearchSample : Window {
    public FlowDocumentSearchSample() {
        InitializeComponent();
    }

    private void BtnSearch_OnClick(object sender, RoutedEventArgs e) {
        FdViewer.Find();
    }
}