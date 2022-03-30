using System.Windows;
using System.Windows.Controls;

namespace HelloWPF.MiscControls;

public partial class ControllingTheTabControlSample : Window {
    public ControllingTheTabControlSample() {
        InitializeComponent();
    }

    private void BtnPreviousTab_OnClick(object sender, RoutedEventArgs e) {
        var newIndex = TcSample.SelectedIndex - 1;
        if (newIndex < 0) newIndex = TcSample.Items.Count - 1;
        TcSample.SelectedIndex = newIndex;
    }

    private void BtnNextTab_OnClick(object sender, RoutedEventArgs e) {
        var newIndex = TcSample.SelectedIndex + 1;
        if (newIndex >= TcSample.Items.Count) newIndex = 0;
        TcSample.SelectedIndex = newIndex;
    }

    private void BtnSelectedTab_OnClick(object sender, RoutedEventArgs e) {
        MessageBox.Show($"Selected tab: {(TcSample.SelectedItem as TabItem)?.Header}");
    }
}