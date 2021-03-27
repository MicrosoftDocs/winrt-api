
using System;
// <Snippetcs_TargetAppNamespaces>
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.ShareTarget;
// </Snippetcs_TargetAppNamespaces>
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareTargetBetaCS
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // <Snippetcs_HandleShare>
        public async Task ActivateAsync(ShareTargetActivatedEventArgs args)
        {
            // <Snippetcs_HandleSharedText>
            ShareOperation shareOperation = args.ShareOperation;
            if (shareOperation.Data.Contains(StandardDataFormats.Text))
            {
                string text = await shareOperation.Data.GetTextAsync();

                // To output the text from this example, you need a TextBlock control
                // with a name of "sharedContent".
                sharedContent.Text = "Text: " + text;
            }
            // </Snippetcs_HandleSharedText>

            if (shareOperation.Data.Contains(StandardDataFormats.StorageItems)) 
            {
                // <Snippetcs_ReportStarted>
                shareOperation.ReportStarted();
                // </Snippetcs_ReportStarted>
                IReadOnlyList<IStorageItem> storageItems = null;
                storageItems = await shareOperation.Data.GetStorageItemsAsync();
                string fileList = String.Empty;

                for (int index = 0; index < storageItems.Count; index++) 
                {
                    fileList += storageItems[index].Name;
                        if (index < storageItems.Count - 1) {
                            fileList += ", ";
                        }
                    }

                // To output the text from this example, you need a TextBlock control
                // with a name of "sharedContent".
                sharedContent.Text += "StorageItems: " + fileList + Environment.NewLine;

                shareOperation.ReportCompleted();
            }

            Window.Current.Content = this;
            Window.Current.Activate();
        }
        // </Snippetcs_HandleShare>

        // Note that the following code if for snippeting only. It's not actually called in 
        // this app. It's derived from the SharingTarget sample, so I'm confident it works.

        // <Snippetcs_HowToCreateAQuickLink>
        async void ReportCompleted(ShareOperation shareOperation, string quickLinkId, string quickLinkTitle)
        {
            QuickLink quickLinkInfo = new QuickLink
            {
                Id = quickLinkId,
                Title = quickLinkTitle,

                // For quicklinks, the supported FileTypes and DataFormats are set 
                // independently from the manifest
                SupportedFileTypes = { "*" },
                SupportedDataFormats = { StandardDataFormats.Text, StandardDataFormats.Uri, 
                        StandardDataFormats.Bitmap, StandardDataFormats.StorageItems }
            };

            StorageFile iconFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.CreateFileAsync(
                    "assets\\user.png", CreationCollisionOption.OpenIfExists);
            quickLinkInfo.Thumbnail = RandomAccessStreamReference.CreateFromFile(iconFile);
            shareOperation.ReportCompleted(quickLinkInfo);
        }
        // </Snippetcs_HowToCreateAQuickLink>
    }
}
