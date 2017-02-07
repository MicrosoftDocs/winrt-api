using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace LaunchApp_WriteTag_CS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        // <SnippetLaunchAppWriteTag1>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;

        private void PublishLaunchApp()
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

	    if (proximityDevice != null)
            {
                // The format of the app launch string is: "<args>\tWindows\t<AppName>".
                // The string is tab or null delimited.

                // The <args> string must have at least one character.
                string launchArgs = "user=default";

                // The format of the AppName is: PackageFamilyName!PRAID.
                string praid = "MyAppId"; // The Application Id value from your package.appxmanifest.

                string appName = Windows.ApplicationModel.Package.Current.Id.FamilyName + "!" + praid;

                string launchAppMessage = launchArgs + "\tWindows\t" + appName;

                var dataWriter = new Windows.Storage.Streams.DataWriter();
                dataWriter.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf16LE;
                dataWriter.WriteString(launchAppMessage);
                var launchAppPubId =
                proximityDevice.PublishBinaryMessage(
                    "LaunchApp:WriteTag", dataWriter.DetachBuffer(), 
                    proximityWriteTagLaunchAppMessageTransmitCallback);
            }
        }

        private void proximityWriteTagLaunchAppMessageTransmitCallback(
            Windows.Networking.Proximity.ProximityDevice sender,
            long messageId)
        {
            // The LaunchApp message has been successfully written to a tag.
        }
        // </SnippetLaunchAppWriteTag1>
    }

    class exclude
    {
        // <SnippetLaunchAppWriteTag2>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;

        private void PublishLaunchApp()
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

	    if (proximityDevice != null)
            {
                // The format of the app launch string is: "<args>\tWindows\t<AppName>".
                // The string is tab or null delimited.

                // The <args> string must have at least one character.
                string launchArgs = "user=default";

                // The format of the AppName is: PackageFamilyName!PRAID.
                string praid = "MyAppId"; // The Application Id value from your package.appxmanifest.

                string appName = Windows.ApplicationModel.Package.Current.Id.FamilyName + "!" + praid;

                string launchAppMessage = launchArgs + "\tWindows\t" + appName;

                var dataWriter = new Windows.Storage.Streams.DataWriter();
                dataWriter.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf16LE;
                dataWriter.WriteString(launchAppMessage);
                var launchAppPubId =
                proximityDevice.PublishBinaryMessage(
                    "LaunchApp:WriteTag", dataWriter.DetachBuffer());
            }
        }
        // </SnippetLaunchAppWriteTag2>
    }
}
