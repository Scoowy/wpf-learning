using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace HelloWPF.MiscControls;

public partial class WebBrowserControlSample : Window {
    public WebBrowserControlSample() {
        InitializeComponent();
        WbSample.Navigate("https://wpf-tutorial.com");
    }

    private void TxtUrl_OnKeyUp(object sender, KeyEventArgs e) {
        if (e.Key == Key.Enter) {
            WbSample.Navigate(TxtUrl.Text);
        }
    }

    private void WbSample_OnNavigating(object sender, NavigatingCancelEventArgs e) {
        TxtUrl.Text = e.Uri.OriginalString;
    }

    private void BrowseBack_OnCanExecute(object sender, CanExecuteRoutedEventArgs e) {
        e.CanExecute = WbSample is { CanGoBack: true };
    }

    private void BrowseBack_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
        WbSample.GoBack();
    }

    private void BrowseForward_OnCanExecute(object sender, CanExecuteRoutedEventArgs e) {
        e.CanExecute = WbSample is { CanGoForward: true };
    }

    private void BrowseForward_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
        WbSample.GoForward();
    }

    private void GoToPage_OnCanExecute(object sender, CanExecuteRoutedEventArgs e) {
        e.CanExecute = true;
    }

    private void GoToPage_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
        WbSample.Navigate(TxtUrl.Text);
    }
}