using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// <Snippetcs_using_datatransfer>
using Windows.ApplicationModel.DataTransfer;
// </Snippetcs_using_datatransfer>
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ClipBoardBetaCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {

        public BlankPage()
        {
            this.InitializeComponent();

            TextInput.DoubleTapped += new DoubleTappedEventHandler(TextInput_DoubleTapped);
            TextInput.RightTapped += new RightTappedEventHandler(TextInput_RightTapped);
            TextOutput.DoubleTapped += new DoubleTappedEventHandler(TextOutput_DoubleTapped);

            // <Snippetcs_AddContentChangedHandler>
            Clipboard.ContentChanged += new EventHandler<object>(this.TrackClipboardChanges_EventHandler);
            // </Snippetcs_AddContentChangedHandler>
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void TextInput_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            String text = ((TextBlock)sender).Text;

            // <Snippetcs_ClipboardGetDataPackage>
            DataPackage dataPackage = new DataPackage();
            // </Snippetcs_ClipboardGetDataPackage>
            // <Snippetcs_ClipboardCopy>
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            // </Snippetcs_ClipboardCopy>
            dataPackage.SetText(text);
            Clipboard.SetContent(dataPackage);
        }

        private void TextInput_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            String text = ((TextBlock)sender).Text;

            DataPackage dataPackage = new DataPackage();
            // <Snippetcs_ClipboardCut_Move>
            dataPackage.RequestedOperation = DataPackageOperation.Move;
            // </Snippetcs_ClipboardCut_Move>

            // <Snippetcs_SetContentToDataPackage>
            dataPackage.SetText("Hello World!");
            // </Snippetcs_SetContentToDataPackage>

            // <Snippetcs_SetContentToClipboard>
            Clipboard.SetContent(dataPackage);
            // </Snippetcs_SetContentToClipboard>
        }

        private async void TextOutput_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            // <Snippetcs_GetClipboardContent>
            DataPackageView dataPackageView = Clipboard.GetContent();
            if (dataPackageView.Contains(StandardDataFormats.Text))
            {
                String text = await dataPackageView.GetTextAsync();

                // To output the text from this example, you need a TextBlock control
                // with a name of "TextOutput".
                TextOutput.Text = "Clipboard now contains: " + text;
            }
            // </Snippetcs_GetClipboardContent>
        }


        // <Snippetcs_TrackClipboardChanges>
        private async void TrackClipboardChanges_EventHandler(object sender, object e)
        {
            DataPackageView dataPackageView = Clipboard.GetContent();
            if (dataPackageView.Contains(StandardDataFormats.Text))
            {
                String text = await dataPackageView.GetTextAsync();

                // To output the text from this example, you need a TextBlock control
                // with a name of "TextOutput".
                TextOutput.Text = "Clipboard now contains: " + text;
            }
        }
        // </Snippetcs_TrackClipboardChanges>

    }
}
