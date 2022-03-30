using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class ListViewColumnSortingSample : Window {
    private GridViewColumnHeader _listViewSortCol = null!;
    private SortAdorner _listViewSortAdorner = null!;

    public ListViewColumnSortingSample() {
        InitializeComponent();

        LvUsers.ItemsSource = new List<User> {
            new User { Name = "John Doe", Age = 42, Sex = SexType.Male },
            new User { Name = "Jane Doe", Age = 39, Sex = SexType.Female },
            new User { Name = "Sammy Doe", Age = 13, Sex = SexType.Male },
            new User { Name = "Donna Doe", Age = 13, Sex = SexType.Female }
        };
    }

    private void LvUsersColumnHeader_OnClick(object sender, RoutedEventArgs e) {
        var column = sender as GridViewColumnHeader;
        var sortBy = column!.Tag.ToString();

        if (_listViewSortCol != null) {
            AdornerLayer.GetAdornerLayer(_listViewSortCol)!.Remove(_listViewSortAdorner);
            LvUsers.Items.SortDescriptions.Clear();
        }

        var newDir = ListSortDirection.Ascending;
        if (_listViewSortCol == column && _listViewSortAdorner.Direction == newDir) {
            newDir = ListSortDirection.Descending;
        }

        _listViewSortCol = column;
        _listViewSortAdorner = new SortAdorner(_listViewSortCol, newDir);
        AdornerLayer.GetAdornerLayer(_listViewSortCol)!.Add(_listViewSortAdorner);
        LvUsers.Items.SortDescriptions.Add(new SortDescription(sortBy!, newDir));
    }
}