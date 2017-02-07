// <SnippetCreateWatcherAllDevicesCs>
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

using Windows.Devices.Enumeration;
using Windows.Devices.Enumeration.Pnp;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Application1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {

            this.InitializeComponent();
        }
        Windows.UI.Core.CoreDispatcher dispatcher;
        public static DeviceWatcher watcher = null;
        public static int count = 0;
        public static DeviceInformation[] interfaces = new DeviceInformation[1000];
        public static bool isEnumerationComplete = false;
        public static string StopStatus = null;

        async void WatchDevices(object sender, RoutedEventArgs eventArgs)
        {
            try
            {
                dispatcher = Window.Current.CoreWindow.Dispatcher;
                watcher = DeviceInformation.CreateWatcher();
                // Add event handlers
                watcher.Added += watcher_Added;
                watcher.Removed += watcher_Removed;
                watcher.Updated += watcher_Updated;
                watcher.EnumerationCompleted += watcher_EnumerationCompleted;
                watcher.Stopped += watcher_Stopped;
                watcher.Start();
                OutputText.Text = "Enumeration started.";

            }
            catch (ArgumentException)
            {
                //The ArgumentException gets thrown by FindAllAsync when the GUID isn't formatted properly
                //The only reason we're catching it here is because the user is allowed to enter GUIDs without validation
                //In normal usage of the API, this exception handling probably wouldn't be necessary when using known-good GUIDs 
                OutputText.Text = "Caught ArgumentException. Failed to create watcher.";
            }
        }

        async void StopWatcher(object sender, RoutedEventArgs eventArgs)
        {
            try
            {
                if (watcher.Status == Windows.Devices.Enumeration.DeviceWatcherStatus.Stopped)
                {
                    StopStatus = "The enumeration is already stopped.";
                }
                else
                {
                    watcher.Stop();
                }
            }
            catch (ArgumentException)
            {
                OutputText.Text = "Caught ArgumentException. Failed to stop watcher.";
            }
        }

        async void watcher_Added(DeviceWatcher sender, DeviceInformation deviceInterface)
        {
            interfaces[count] = deviceInterface;
            count += 1;
            if (isEnumerationComplete)
            {
                await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    DisplayDeviceInterfaceArray();
                });
            }
        }

        async void watcher_Updated(DeviceWatcher sender, DeviceInformationUpdate devUpdate)
        {
            int count2 = 0;
            foreach (DeviceInformation deviceInterface in interfaces)
            {
                if (count2 < count)
                {
                    if (interfaces[count2].Id == devUpdate.Id)
                    {
                        //Update the element.
                        interfaces[count2].Update(devUpdate);
                    }

                }
                count2 += 1;
            }
            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                OutputText.Text = "Enumeration updated. ";
                DisplayDeviceInterfaceArray();
            });
        }

        async void watcher_Removed(DeviceWatcher sender, DeviceInformationUpdate devUpdate)
        {
            int count2 = 0;
            //Convert interfaces array to a list (IList).
            List<DeviceInformation> interfaceList = new List<DeviceInformation>(interfaces);
            foreach (DeviceInformation deviceInterface in interfaces)
            {
                if (count2 < count)
                {
                    if (interfaces[count2].Id == devUpdate.Id)
                    {
                        //Remove the element.
                        interfaceList.RemoveAt(count2);
                    }

                }
                count2 += 1;
            }
            //Convert the list back to the interfaces array.
            interfaces = interfaceList.ToArray();
            count -= 1;
            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                OutputText.Text = "Enumeration device was removed. ";
                DisplayDeviceInterfaceArray();
            });
        }

        async void watcher_EnumerationCompleted(DeviceWatcher sender, object args)
        {
            isEnumerationComplete = true;
            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    OutputText.Text = "Enumeration complete. ";
                    DisplayDeviceInterfaceArray();
                });
        }

        async void watcher_Stopped(DeviceWatcher sender, object args)
        {
            if (watcher.Status == Windows.Devices.Enumeration.DeviceWatcherStatus.Aborted)
            {
                StopStatus = "Enumeration stopped unexpectedly. Click Watch to restart enumeration.";
            }
            else if (watcher.Status == Windows.Devices.Enumeration.DeviceWatcherStatus.Stopped)
            {
                StopStatus = "You requested to stop the enumeration. Click Watch to restart enumeration.";
            }
        }

        async void DisplayDeviceInterfaceArray()
        {
            DeviceInterfacesOutputList.Items.Clear();
            int count2 = 0;
            foreach (DeviceInformation deviceInterface in interfaces)
            {
                if (count2 < count)
                {
                    DisplayDeviceInterface(deviceInterface);
                }
                count2 += 1;
            }
        }

        async void DisplayDeviceInterface(DeviceInformation deviceInterface)
        {
            var id = "Id:" + deviceInterface.Id;
            var name = deviceInterface.Name;
            var isEnabled = "IsEnabled:" + deviceInterface.IsEnabled;


            var item = id + " is \n" + name + " and \n" + isEnabled;

            DeviceInterfacesOutputList.Items.Add(item);
        }
    }
}
// </SnippetCreateWatcherAllDevicesCs>
