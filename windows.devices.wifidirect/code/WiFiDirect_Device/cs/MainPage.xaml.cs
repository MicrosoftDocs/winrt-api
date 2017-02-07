using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace WiFiDirectDeviceSnippets
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

        // <Snippet1>
        private async System.Threading.Tasks.Task<IEnumerable<String>> GetWiFiDirectDevices()
        {
            try
            {
                String deviceSelector = Windows.Devices.WiFiDirect.WiFiDirectDevice.GetDeviceSelector();
                var devInfoCollection = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(deviceSelector);
                return from devInfo in devInfoCollection
                       select devInfo.Name;
            }
            catch
            {
                // Handle error.
                return null;
            }
        }
        // </Snippet1>

        // <Snippet2>
        Windows.Devices.WiFiDirect.WiFiDirectDevice wfdDevice;
        private async System.Threading.Tasks.Task<String> Connect(string deviceId)
        {
            string result = ""; 

            try
            {
                // No device Id specified.
                if (String.IsNullOrEmpty(deviceId)) { return "Please specify a Wi- Fi Direct device Id."; }

                // Connect to the selected Wi-Fi Direct device.
                wfdDevice = await Windows.Devices.WiFiDirect.WiFiDirectDevice.FromIdAsync(deviceId);

                if (wfdDevice == null)
                {
                    result = "Connection to " + deviceId + " failed.";
                }

                // Register for connection status change notification.
                wfdDevice.ConnectionStatusChanged += new TypedEventHandler<Windows.Devices.WiFiDirect.WiFiDirectDevice, object>(OnConnectionChanged);

                // Get the EndpointPair information.
                var EndpointPairCollection = wfdDevice.GetConnectionEndpointPairs();

                if (EndpointPairCollection.Count > 0)
                {
                    var endpointPair = EndpointPairCollection[0];
                    result = "Local IP address " + endpointPair.LocalHostName.ToString() + 
                        " connected to remote IP address " + endpointPair.RemoteHostName.ToString();
                }
                else
                {
                   result = "Connection to " + deviceId + " failed.";
                }
            }
            catch (Exception err)
            {
                // Handle error.
                result = "Error occurred: " + err.Message;
            }

            return result;
        }

        private void OnConnectionChanged(object sender, object arg)
        {
            Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus status = 
                (Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus)arg;

            if (status == Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus.Connected)
            {
                // Connection successful.
            }
            else
            {
                // Disconnected.
                Disconnect();
            }
        }

        private void Disconnect()
        {
            if (wfdDevice != null) 
            {
                wfdDevice.Dispose(); 
            }
        }
        // </Snippet2>
    }
}
