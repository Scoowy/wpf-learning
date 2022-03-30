using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HelloWPF.ComboBoxControl;

public partial class ComboBoxSelectionSample : Window {
    public ComboBoxSelectionSample() {
        InitializeComponent();
        CmbColors.ItemsSource = typeof(Colors).GetProperties();
    }

    private void BtnPrevious_OnClick(object sender, RoutedEventArgs e) {
        if (CmbColors.SelectedIndex > 0) {
            CmbColors.SelectedIndex -= 1;
        }
    }

    private void BtnNext_OnClick(object sender, RoutedEventArgs e) {
        if (CmbColors.SelectedIndex < CmbColors.Items.Count - 1) {
            CmbColors.SelectedIndex += 1;
        }
    }

    private void BtnBlue_OnClick(object sender, RoutedEventArgs e) {
        CmbColors.SelectedItem = typeof(Colors).GetProperty("Blue");
    }

    private void CmbColors_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
        var selectedColor = (Color)(CmbColors.SelectedItem as PropertyInfo)?.GetValue(null, null)!;
        this.Background = new SolidColorBrush(selectedColor);
    }
}