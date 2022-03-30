using System;
using System.Windows;
using System.Windows.Controls;

namespace HelloWPF.MiscControls;

public partial class CalendarBlockedoutDatesSample : Window {
    public CalendarBlockedoutDatesSample() {
        InitializeComponent();
        CldSample.BlackoutDates.AddDatesInPast();
        CldSample.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
    }
}