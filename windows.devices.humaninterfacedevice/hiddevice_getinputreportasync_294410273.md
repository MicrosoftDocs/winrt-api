---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetInputReportAsync(System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.HumanInterfaceDevice.HidInputReport> GetInputReportAsync(System.UInt16 reportId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetInputReportAsync

## -description
Asynchronously retrieves an input report, identified by the *reportId* parameter, from the given HID device.

## -parameters
### -param reportId
Identifies the requested input report.

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

[GetInputReportAsync](hiddevice_getinputreportasync_2092816092.md), [Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
