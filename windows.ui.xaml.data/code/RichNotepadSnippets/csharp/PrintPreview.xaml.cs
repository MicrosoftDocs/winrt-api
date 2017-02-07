using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Imaging;

namespace RichNotepad
{
    public partial class PrintPreview : ChildWindow
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        //<SnippetPrintPreviewCode>
        public void ShowPreview(RichTextBox rtb)
        {            
            WriteableBitmap image = new WriteableBitmap(rtb, null);
            previewImage.Source = image;            
        }
        //</SnippetPrintPreviewCode>

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

