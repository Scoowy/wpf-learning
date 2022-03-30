using System.Windows;
using System.Windows.Controls;

namespace HelloWPF.CommonInterfaceControls;

public partial class ContextMenuManuallyInvokedSample : Window
{
    public ContextMenuManuallyInvokedSample()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        var ctxMenu = this.FindResource("CtxMenu") as ContextMenu;
        ctxMenu!.PlacementTarget = sender as Button;
        ctxMenu.IsOpen = true;
    }
}