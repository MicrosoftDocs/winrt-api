---
-api-id: M:Windows.Devices.Display.DisplayMonitor.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<DisplayMonitor> DisplayMonitor.FromIdAsync(String deviceId)
-->

# Windows.Devices.Display.DisplayMonitor.FromIdAsync

## -description
Asynchronously creates a [DisplayMonitor](displaymonitor.md) object for the specified device identifier.

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

