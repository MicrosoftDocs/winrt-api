---
-api-id: T:Windows.Devices.Usb.UsbInterface
-api-type: winrt class
---

<!-- Class syntax.
public class UsbInterface : Windows.Devices.Usb.IUsbInterface
-->

# Windows.Devices.Usb.UsbInterface

## -description
Provides information about the USB interface including its endpoints, the number of alternate settings the interface supports, and gets the entire descriptor set for those settings. It also obtains pipes associated with the endpoints that the interface supports.

## -remarks

## -examples
This code example shows how to parse descriptors and get pipe objects. The example assumes that the app has previously obtained the [UsbDevice](usbdevice.md) object.

```csharp
using Windows.Devices.Usb;
using Windows.Storage.Streams;

protected override async void OnLaunched(LaunchActivatedEventArgs args)
{

    UsbDevice device;
    UInt32 readLen = 8;

    // Get the UsbDevice object. Not shown.

    ...
    
    UsbInterface myInterface = null;

    //
    // Need to find this descriptor after an interface descriptor:
    //
    //   ===>Class-Specific Video Control Interface Header Descriptor<===
    // bLength:   0x0D
    // bDescriptorType:   0x24
    // bDescriptorSubtype:0x01
    // bcdVDC:  0x0100
    // wTotalLength:    0x00D9  -> Validated
    // dwClockFreq: 0x02DC6C00 = (48000000) Hz
    // bInCollection:     0x01
    // baInterfaceNr[1]:  0x01
    // USB Video Class device: spec version 1.0
    //
    foreach (var interf in device.Configuration.UsbInterfaces)
    {
        foreach (var setting in interf.InterfaceSettings)
        {
            var descriptors = setting.Descriptors;
            
            // First descriptor in the setting must be the interface descriptor
            if (descriptors.Count >= 2 &&
                UsbInterfaceDescriptor.TryParse(descriptors[0], null) == 
                                            true && 
                                            descriptors[1].Length == 0x0D &&
                                            descriptors[1].DescriptorType == 0x24)
            {
                Windows.Storage.Streams.Buffer buffer = new Windows.Storage.Streams.Buffer(readLen);
                descriptors[1].readDescriptorBuffer(buffer);
                Windows.Storage.Streams.DataReader reader = Windows.Storage.Streams.DataReader.FromBuffer(buffer);

                reader.ReadByte(); // bLength
                reader.ReadByte(); // bDescriptorType
                byte bDescriptorSubType = reader.ReadByte();

                if (bDescriptorSubType == 0x01) 
                {
                    // This is our interface.
                    myInterface = interf;
                    ushort bcdVDC = reader.ReadUInt16();
                    ushort wTotalLength = reader.ReadUInt16();
                    byte lsb = reader.ReadByte();
                    uint dwClockFreq = (reader.ReadUInt16() << 8) + lsb;
                    byte bInCollection = reader.ReadByte();
                    byte baInterfaceNr1 = reader.ReadByte();

                    await setting.SelectSettingAsync();
                }
                break;
            }
        }

        if (myInterface != null)
        {
            break;
        }
    }

    if (myInterface == null)
    {
        ShowError("Video Control Interface descriptor not found");
        return;
    }

    // Pipes are now available to communicate with endpoints

    UsbInterruptInPipe interruptIn = myInterface.InterruptInPipes[0];
    UsbBulkOutPipe bulkOut = myInterface.BulkOutPipes[0];

}

```



## -see-also
