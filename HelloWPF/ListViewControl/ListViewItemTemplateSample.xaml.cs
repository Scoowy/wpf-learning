using System.Collections.Generic;
using System.Windows;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class ListViewItemTemplateSample : Window {
    public ListViewItemTemplateSample() {
        InitializeComponent();

        var items = new List<User>() {
            new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" },
            new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" },
            new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" }
        };

        LvDataBinding.ItemsSource = items;
    }
}