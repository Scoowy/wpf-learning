using System.Collections.ObjectModel;

namespace HelloWPF.Models;

public class MenuItem {
    public MenuItem() {
        this.Items = new ObservableCollection<MenuItem>();
    }

    public string? Title { get; set; }

    public ObservableCollection<MenuItem> Items { get; set; }
}