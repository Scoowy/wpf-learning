using System.Collections.Generic;
using System.Windows;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class ListViewDataBindingSample : Window {
    public ListViewDataBindingSample() {
        InitializeComponent();

        var items = new List<User>() {
            new User() { Name = "John Doe", Age = 42 },
            new User() { Name = "Jane Doe", Age = 39 },
            new User() { Name = "Sammy doe", Age = 13 }
        };

        LvDataBinding.ItemsSource = items;
    }
}