using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class FilteringSample : Window {
    public FilteringSample() {
        InitializeComponent();

        LvUsers.ItemsSource = new List<User> {
            new User { Name = "John Doe", Age = 42 },
            new User { Name = "Jane Doe", Age = 39 },
            new User { Name = "Sammy Doe", Age = 13 },
            new User { Name = "Donna Doe", Age = 13 }
        };

        var view = (CollectionView)CollectionViewSource.GetDefaultView(LvUsers.ItemsSource);
        view.Filter = UserFilter;
    }

    private bool UserFilter(object item) {
        return string.IsNullOrEmpty(TxtFilter.Text) ||
               (item as User)!.Name.Contains(TxtFilter.Text, StringComparison.OrdinalIgnoreCase);
    }

    private void TxtFilter_OnTextChanged(object sender, TextChangedEventArgs e) {
        CollectionViewSource.GetDefaultView(LvUsers.ItemsSource).Refresh();
    }
}