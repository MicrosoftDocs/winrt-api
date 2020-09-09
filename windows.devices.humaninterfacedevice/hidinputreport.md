---
-api-id: T:Windows.Devices.HumanInterfaceDevice.HidInputReport
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class HidInputReport : Windows.Devices.HumanInterfaceDevice.IHidInputReport
-->

# Windows.Devices.HumanInterfaceDevice.HidInputReport

## -description

Represents a [HID Input Report](/windows-hardware/drivers/hid/introduction-to-hid-concepts#reports).

Devices issue input reports to describe state changes, user-input, and other device-specific data. For example, a HID keyboard device would use an input report to signal a key press. A HID presence-sensor would use an input report to signal a presence detection event.

## -remarks

The following example demonstrates how a UWP app built with XAML and C# uses the **GetInputReportAsync** method to obtain an input report.

```csharp
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
    class Vendor
    {
        private async void ReadWriteToHidDevice(HidDevice device)
        {
            if (device != null)
            {
                // construct a HID output report to send to the device
                HidOutputReport outReport = device.CreateOutputReport();

                /// Initialize the data buffer and fill it in
                byte[] buffer = new byte[] { 10, 20, 30, 40 };

                DataWriter dataWriter = new DataWriter();
                dataWriter.WriteBytes(buffer);

                outReport.Data = dataWriter.DetachBuffer();

                // Send the output report asynchronously
                await device.SendOutputReportAsync(outReport);

                //
                // Sent output report successfully 
                // Now lets try read an input report 
                //
                HidInputReport inReport = await device.GetInputReportAsync();

                if (inReport != null)
                {
                    UInt16 id = inReport.Id;
                    var bytes = new byte[4];
                    DataReader dataReader = DataReader.FromBuffer(inReport.Data);
                    dataReader.ReadBytes(bytes);
                }
                else
                {
                    this.NotifyUser("Invalid input report received");
                }
            }
            else
            {
                this.NotifyUser("device is NULL");
            }
        }
    }
}


```



## -examples

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
