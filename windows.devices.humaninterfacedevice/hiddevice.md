---
-api-id: T:Windows.Devices.HumanInterfaceDevice.HidDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class HidDevice : Windows.Devices.HumanInterfaceDevice.IHidDevice, Windows.Foundation.IClosable
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice

## -description
Represents a top-level collection and the corresponding device.

## -remarks
The following example demonstrates how a Windows Store app built with XAML and C# uses the **GetDeviceSelector** method to create a selector for a specific HID device and then uses** FromIdAsync** method to open a connection to that device.





```css
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Devices.Enumeration;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Storage;
using Windows.Storage.Streams;

namespace HidSampleCS
{
    class Enumeration
    {
        // Enumerate HID devices
        private async void EnumerateHidDevices()
        {
            UInt32 vendorId = 0x045E;
            UInt32 productId = 0x078F;
            UInt32 usagePage = 0xFF00;
            UInt32 usageId = 0x0001;

            // Create a selector that gets a HID device using VID/PID and a 
            // VendorDefined usage
            string selector = HidDevice.GetDeviceSelector(usagePage, usageId, 
                              vendorId, productId);

            // Enumerate devices using the selector
            var devices = await DeviceInformation.FindAllAsync(selector);

            if (devices.Count > 0)
            {
                // Open the target HID device
                HidDevice device = await HidDevice.FromIdAsync(devices.ElementAt(0).Id, 
                                   FileAccessMode.ReadWrite);

                // At this point the device is available to communicate with
                // So we can send/receive HID reports from it or 
                // query it for control descriptions
            }
            else
            {
                // There were no HID devices that met the selector criteria
                this.NotifyUser("MUTT HID device not found");
            }
        }
    }
}


```



## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)