---
-api-id: M:Windows.Devices.Display.DisplayMonitor.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<DisplayMonitor> DisplayMonitor.FromIdAsync(String deviceId)
-->

# Windows.Devices.Display.DisplayMonitor.FromIdAsync

## -description
Asynchronously creates a [DisplayMonitor](displaymonitor.md) object for the specified device identifier (a string containing a PnP device instance path). See the code example below.

> [!NOTE]
> The argument must be a device identifier, and not a device interface identifier. If you have a device interface identifier (which is likely), then call [FromInterfaceIdAsync](displaymonitor_frominterfaceidasync_1923441009.md) instead. For more details, see [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md).

## -parameters
### -param deviceId
The monitor device identifier. See [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md).

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

IAsyncAction EnumerateDisplayMonitorsUsingAdditionalPropertiesAsync()
{
    winrt::hstring propertyName = L"System.Devices.DeviceInstanceId";
    auto const dis{ co_await DeviceInformation::FindAllAsync(DisplayMonitor::GetDeviceSelector(), { propertyName }) };

    for (auto const& deviceInformation : dis)
    {
        WINRT_ASSERT(deviceInformation.Kind() == DeviceInformationKind::DeviceInterface);
        DisplayMonitor displayMonitor{ co_await DisplayMonitor::FromIdAsync(winrt::unbox_value<winrt::hstring>(deviceInformation.Properties().Lookup(propertyName))) };
    }
}
```
