using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace HelloWPF.RichTextControls;

public partial class CodeBehindFlowDocumentSample : Window {
    public CodeBehindFlowDocumentSample() {
        InitializeComponent();

        var doc = new FlowDocument();

        var p = new Paragraph(new Run("Hello, world!")) {
            FontSize = 36
        };
        doc.Blocks.Add(p);

        p = new Paragraph(new Run("The ultimate programming greeting!")) {
            FontSize = 14,
            FontStyle = FontStyles.Italic,
            TextAlignment = TextAlignment.Left,
            Foreground = Brushes.Gray
        };
        doc.Blocks.Add(p);

        FdViewer.Document = doc;
    }
}