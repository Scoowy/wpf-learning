using System.Collections.Generic;
using System.Windows;
using HelloWPF.Models;

namespace HelloWPF.ItemsControl;

public partial class ItemsControlDataBindingSample : Window {
    public ItemsControlDataBindingSample() {
        InitializeComponent();

        var items = new List<TodoItem> {
            new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 },
            new TodoItem() { Title = "Learn C#", Completion = 80 },
            new TodoItem() { Title = "Wash the car", Completion = 0 }
        };

        IcTodoList.ItemsSource = items;
    }
}