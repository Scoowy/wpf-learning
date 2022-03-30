using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using HelloWPF.Annotations;
using HelloWPF.Models;

namespace HelloWPF.DataBinding;

public partial class ChangeNotificationSample : Window {
    private ObservableCollection<User> _users = new ObservableCollection<User>();

    public ChangeNotificationSample() {
        InitializeComponent();

        _users.Add(new User() { Name = "John Doe" });
        _users.Add(new User() { Name = "Jane Doe" });

        LblUsers.ItemsSource = _users;
    }

    private void BtnAddUser_OnClick(object sender, RoutedEventArgs e) {
        _users.Add(new User() { Name = "New user" });
    }

    private void BtnChangeUser_OnClick(object sender, RoutedEventArgs e) {
        if (LblUsers.SelectedItem == null) return;
        (LblUsers.SelectedItem as User)!.Name = "Random Name";
    }

    private void BtnDeleteUser_OnClick(object sender, RoutedEventArgs e) {
        _users.Remove((LblUsers.SelectedItem as User)!);
    }
}