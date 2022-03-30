using System;
using System.Windows;

namespace HelloWPF.MiscControls;

public partial class CalendarSelectionSample : Window {
    public CalendarSelectionSample() {
        InitializeComponent();
        CldSample.SelectedDate = DateTime.Now.AddDays(1);
    }
}