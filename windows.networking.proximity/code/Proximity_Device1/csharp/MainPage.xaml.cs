using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace ProximityEvents
{
    partial class MainPage
    {

        // <SnippetInitialize_CS>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;

        public MainPage()
        {
            InitializeComponent();

            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (proximityDevice != null)
            {
                proximityDevice.DeviceArrived += ProximityDeviceArrived;
                proximityDevice.DeviceDeparted += ProximityDeviceDeparted;
            }
            else
            {
                MessageTextBlock.Text += "Failed to initialize proximity device.\n";
            }
        }
        // </SnippetInitialize_CS>

        // <SnippetEvents_CS>
	Windows.UI.Core.CoreDispatcher _dispatcher = Window.Current.Dispatcher;

        private async void ProximityDeviceArrived(object sender)
        {
	    await _dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
		() =>
		{
            		MessageTextBlock.Text += "Proximate device arrived.\n";
		});
        }

        private async void ProximityDeviceDeparted(object sender)
        {
	    await _dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
		() =>
		{
            		MessageTextBlock.Text += "Proximate device departed.\n";
		});
        }       
        // </SnippetEvents_CS>
        
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
  

    }
}
