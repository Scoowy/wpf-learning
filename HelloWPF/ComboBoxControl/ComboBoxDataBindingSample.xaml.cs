using System.Windows;
using System.Windows.Media;

namespace HelloWPF.ComboBoxControl;

public partial class ComboBoxDataBindingSample : Window {
    public ComboBoxDataBindingSample() {
        InitializeComponent();
        CmbColors.ItemsSource = typeof(Colors).GetProperties();
    }
}