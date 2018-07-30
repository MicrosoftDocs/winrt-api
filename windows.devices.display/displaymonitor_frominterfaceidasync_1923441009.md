---
-api-id: M:Windows.Devices.Display.DisplayMonitor.FromInterfaceIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<DisplayMonitor> DisplayMonitor.FromInterfaceIdAsync(String deviceInterfaceId)
-->

# Windows.Devices.Display.DisplayMonitor.FromInterfaceIdAsync

## -description
Asynchronously creates a [DisplayMonitor](displaymonitor.md) object for the specified monitor interface identifier (a string containing a PnP device interface path). See the code example below.

> [!NOTE]
> If you call [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md), passing the Advanced Query Syntax (AQS) device interface selector string returned by [DisplayMonitor.GetDeviceSelector](displaymonitor_getdeviceselector_838466080.md), then you will retrieve a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects that describe monitor interfaces (rather than monitor devices). Accessing the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) property on one of those objects retrieves a monitor interface identifier, which you can pass to **DisplayMonitor.FromInterfaceIdAsync**. See the code example below.
>
> Most Win32 APIs that provide a monitor identifier actually provide the monitor interface identifier (and not the device identifier).

## -parameters
### -param deviceInterfaceId
The monitor interface identifier

## -returns
An asynchronous create operation.

## -remarks

## -see-also

## -examples
```cppwinrt
using namespace winrt;
using namespace Windows::Devices::Display;
using namespace Windows::Devices::Enumeration;
using namespace Windows::Foundation;

IAsyncAction EnumerateDisplayMonitorsAsync()
{
    auto const dis{ co_await DeviceInformation::FindAllAsync(DisplayMonitor::GetDeviceSelector()) };

    for (auto const& deviceInformation : dis)
    {
        WINRT_ASSERT(deviceInformation.Kind() == DeviceInformationKind::DeviceInterface);
        DisplayMonitor displayMonitor{ co_await DisplayMonitor::FromInterfaceIdAsync(deviceInformation.Id()) };
    }
}
```