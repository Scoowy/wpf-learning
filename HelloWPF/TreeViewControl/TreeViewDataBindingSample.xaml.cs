using System.Windows;
using HelloWPF.Models;

namespace HelloWPF.TreeViewControl;

public partial class TreeViewDataBindingSample : Window {
    public TreeViewDataBindingSample() {
        InitializeComponent();

        var root = new MenuItem { Title = "Menu" };

        var childItem1 = new MenuItem { Title = "Child item #1" };
        childItem1.Items.Add(new MenuItem { Title = "Child item #1.1" });
        childItem1.Items.Add(new MenuItem { Title = "Child item #1.2" });

        root.Items.Add(childItem1);
        root.Items.Add(new MenuItem { Title = "Child item #2" });

        TrvMenu.Items.Add(root);
    }
}