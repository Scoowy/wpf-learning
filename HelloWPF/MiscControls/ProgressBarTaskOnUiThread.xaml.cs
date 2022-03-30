using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace HelloWPF.MiscControls;

public partial class ProgressBarTaskOnUiThread : Window {
    public ProgressBarTaskOnUiThread() {
        InitializeComponent();
    }

    private void Window_OnContentRendered(object? sender, EventArgs e) {
        var worker = new BackgroundWorker();
        worker.WorkerReportsProgress = true;
        worker.DoWork += Worker_DoWork;
        worker.ProgressChanged += Worker_OnProgressChanged;

        worker.RunWorkerAsync();
    }

    void Worker_DoWork(object sender, DoWorkEventArgs e) {
        for (var i = 0; i <= 100; i++) {
            (sender as BackgroundWorker)?.ReportProgress(i);
            Thread.Sleep(100);
        }
    }

    void Worker_OnProgressChanged(object sender, ProgressChangedEventArgs e) {
        PbStatus.Value = e.ProgressPercentage;
    }
}