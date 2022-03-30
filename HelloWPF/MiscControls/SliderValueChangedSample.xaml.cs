using System.Windows;
using System.Windows.Media;

namespace HelloWPF.MiscControls;

public partial class SliderValueChangedSample : Window {
    public SliderValueChangedSample() {
        InitializeComponent();
    }

    private void ColorSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
        var color = Color.FromArgb(255, (byte)SldColorR.Value, (byte)SldColorG.Value, (byte)SldColorB.Value);
        this.Background = new SolidColorBrush(color);
    }
}