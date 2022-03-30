using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class ListViewSortingSample : Window {
    public ListViewSortingSample() {
        InitializeComponent();

        var items = new List<User> {
            new User { Name = "John Doe", Age = 42 },
            new User { Name = "Jane Doe", Age = 39 },
            new User { Name = "Sammy Doe", Age = 13 },
            new User { Name = "Donna Doe", Age = 13 },
        };

        LvUsers.ItemsSource = items;

        var view = (CollectionView)CollectionViewSource.GetDefaultView(LvUsers.ItemsSource);
        view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
        view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
    }
}