using System.Collections.Generic;
using System.Windows;
using HelloWPF.Models;

namespace HelloWPF.TreeViewControl;

public partial class TreeViewMultipleTemplatesSample : Window {
    public TreeViewMultipleTemplatesSample() {
        InitializeComponent();

        var families = new List<Family>();

        var family1 = new Family { Name = "The Doe's" };
        family1.Members.Add(new FamilyMember { Name = "John Doe", Age = 42 });
        family1.Members.Add(new FamilyMember { Name = "Jane Doe", Age = 39 });
        family1.Members.Add(new FamilyMember { Name = "Sammy Doe", Age = 13 });
        families.Add(family1);

        var family2 = new Family { Name = "The Moe's" };
        family2.Members.Add(new FamilyMember { Name = "Mark Moe", Age = 31 });
        family2.Members.Add(new FamilyMember { Name = "Norma Moe", Age = 28 });
        families.Add(family2);

        TrvFamilies.ItemsSource = families;
    }
}