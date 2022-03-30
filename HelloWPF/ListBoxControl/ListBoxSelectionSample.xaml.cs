using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using HelloWPF.Models;

namespace HelloWPF.ListBoxControl;

public partial class ListBoxSelectionSample : Window {
    public ListBoxSelectionSample() {
        InitializeComponent();

        var items = new List<TodoItem>() {
            new TodoItem { Title = "Complete this WPF tutorial", Completion = 45 },
            new TodoItem { Title = "Learn C#", Completion = 80 },
            new TodoItem { Title = "Wash the car", Completion = 0 }
        };

        LbTodoList.ItemsSource = items;
    }

    private void LbTodoList_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (LbTodoList.SelectedItem is not null) {
            this.Title = (LbTodoList.SelectedItem as TodoItem)!.Title;
        }
    }

    private void BtnShowSelectedItem_OnClick(object sender, RoutedEventArgs e) {
        foreach (var item in LbTodoList.SelectedItems) {
            MessageBox.Show((item as TodoItem)!.Title);
        }
    }

    private void BtnSelectLast_OnClick(object sender, RoutedEventArgs e) {
        LbTodoList.SelectedIndex = LbTodoList.Items.Count - 1;
    }

    private void BtnSelectNext_OnClick(object sender, RoutedEventArgs e) {
        var nextIndex = 0;
        if (LbTodoList.SelectedIndex >= 0 && LbTodoList.SelectedIndex < LbTodoList.Items.Count - 1) {
            nextIndex = LbTodoList.SelectedIndex + 1;
        }

        LbTodoList.SelectedIndex = nextIndex;
    }

    private void BtnSelectCSharp_OnClick(object sender, RoutedEventArgs e) {
        foreach (var item in LbTodoList.Items) {
            if (item is not TodoItem todoItem || !todoItem.Title.Contains("C#")) continue;
            LbTodoList.SelectedItem = todoItem;
            break;
        }
    }

    private void BtnSelectAll_OnClick(object sender, RoutedEventArgs e) {
        foreach (var item in LbTodoList.Items) {
            LbTodoList.SelectedItems.Add(item);
        }
    }
}