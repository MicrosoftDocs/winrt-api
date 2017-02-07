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

namespace Proximity_GetDeviceSelector1_CS
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
            InitializeProximity();
            QueryDeviceProperties();
        }

        // <SnippetGetDeviceSelector>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;

        private async void InitializeProximity()
        {
            string selectorString = Windows.Networking.Proximity.ProximityDevice.GetDeviceSelector();

            var deviceInfoCollection =
                await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(selectorString, null);

                if (deviceInfoCollection.Count == 0)
                {
                    StatusTextBlock.Text = "No proximity devices found.";
                } 
                else 
                {
                    StatusTextBlock.Text = "Proximity Device id = " + deviceInfoCollection[0].Id;
                    proximityDevice =
                        Windows.Networking.Proximity.ProximityDevice.FromId(deviceInfoCollection[0].Id);
                }
        }
        //</SnippetGetDeviceSelector>


        // <SnippetDeviceId>
        private async void QueryDeviceProperties()
        {
            // Include the proximity properties key
            var propertiesToRetrieve = new List<String> {"{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"};

            var defaultProximityDevice =
                Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (defaultProximityDevice != null)
            {
                var devInfo = await Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(
                    defaultProximityDevice.DeviceId, propertiesToRetrieve);

                if (devInfo.Properties.ContainsKey("{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"))
                {
                    var proximityCapabilities =
                        devInfo.Properties["{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"] as string[];
                    if (proximityCapabilities.Contains("StandardNfc"))
                    {
                        // This proximity device supports NFC
                    }
                }
            }
        }
        // </SnippetDeviceId>
    }
}
