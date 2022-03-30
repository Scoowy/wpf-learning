using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HelloWPF.DataBinding;

public partial class CodeBehindBindingSample : Window
{
    public CodeBehindBindingSample()
    {
        InitializeComponent();

        var binding = new Binding("Text")
        {
            Source = TxtValue
        };
        
        LblValue.SetBinding(TextBlock.TextProperty, binding);
    }
}