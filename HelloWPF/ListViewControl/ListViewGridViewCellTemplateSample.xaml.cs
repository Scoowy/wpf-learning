using System.Collections.Generic;
using System.Windows;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class ListViewGridViewCellTemplateSample : Window {
    public ListViewGridViewCellTemplateSample() {
        InitializeComponent();

        var items = new List<User> {
            new User { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" },
            new User { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" },
            new User { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" }
        };
        LvUsers.ItemsSource = items;
    }
}