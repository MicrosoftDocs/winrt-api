---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetInputReportAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.HumanInterfaceDevice.HidInputReport> GetInputReportAsync()
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetInputReportAsync

## -description
Asynchronously retrieves the default, or first, input report from the given HID device.

## -returns
A **HidInputReport** object.

## -remarks
When this method completes, the [InputReportReceived](hiddevice_inputreportreceived.md) event is triggered.

To access the content of the input report, you must set up a listener for the [InputReportReceived](hiddevice_inputreportreceived.md) event and get the [Report](/uwp/api/windows.devices.humaninterfacedevice.hidinputreportreceivedeventargs#Windows_Devices_HumanInterfaceDevice_HidInputReportReceivedEventArgs_Report) property of [HidInputReportReceivedEventArgs](/uwp/api/windows.devices.humaninterfacedevice.hidinputreportreceivedeventargs) object in the event handler.

The device must be opened with either [FileAccessMode.Read](../windows.storage/fileaccessmode.md) or [FileAccessMode.ReadWrite](../windows.storage/fileaccessmode.md).

## -examples
Here, we retrieve an input report (inputReport) and get the content of the report in the handler for the InputReportReceived event,  triggered when the asynchronous call completes.

```csharp
HidInputReport inputReport = await device.GetInputReportAsync();
.
.
.
private void InputReportReceived(
    HidDevice sender, 
    HidInputReportReceivedEventArgs args)
    {
        HidInputReport inputReport = args.Report;
        IBuffer buffer = inputReport.Data;
        DataReader dr = DataReader.FromBuffer(buffer);
        byte[] bytes = new byte[inputReport.Data.Length];
        dr.ReadBytes(bytes);

        String inputReportContent = 
           System.Text.Encoding.ASCII.GetString(bytes);
    }
```

## -see-also

### Reference

[GetInputReportAsync(UInt16)](hiddevice_getinputreportasync_294410273.md), [Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
