using System;
using System.Windows.Controls;

namespace HelloWPF.UserControls;

public partial class LimitedInputUserControl : UserControl
{
    public LimitedInputUserControl()
    {
        InitializeComponent();
        this.DataContext = this;
    }

    public string? Title { get; set; }

    public int MaxLength { get; set; }
}