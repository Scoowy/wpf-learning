using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using HelloWPF.Models;

namespace HelloWPF.ListViewControl;

public partial class ListViewGroupSample : Window {
    public ListViewGroupSample() {
        InitializeComponent();

        var items = new List<User> {
            new User { Name = "John Doe", Age = 42, Sex = SexType.Male },
            new User { Name = "Jane Doe", Age = 39, Sex = SexType.Female },
            new User { Name = "Sammy Doe", Age = 7, Sex = SexType.Male }
        };
        LvUsers.ItemsSource = items;

        var view = (CollectionView)CollectionViewSource.GetDefaultView(LvUsers.ItemsSource);
        var groupDescription = new PropertyGroupDescription("Sex");

        view.GroupDescriptions?.Add(groupDescription);
    }
}