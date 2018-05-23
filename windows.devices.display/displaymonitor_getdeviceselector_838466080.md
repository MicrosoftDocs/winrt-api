---
-api-id: M:Windows.Devices.Display.DisplayMonitor.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax.
public string DisplayMonitor.GetDeviceSelector()
-->

# Windows.Devices.Display.DisplayMonitor.GetDeviceSelector

## -description
Returns an Advanced Query Syntax (AQS) device interface selector string.

The selector can be used by [DeviceInformation.CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) to watch and enumerate monitor devices on the system. Or it can be used with [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) to retrieve a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects that describe monitor interfaces (rather than monitor devices). Accessing the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) property on one of those objects retrieves a monitor interface identifier, which you can pass to [DisplayMonitor.FromInterfaceIdAsync](displaymonitor_frominterfaceidasync_1923441009.md).

## -returns
An Advanced Query Syntax (AQS) device interface selector string.

## -remarks

## -see-also
[DeviceInformation.CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md), [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md), [DisplayMonitor.FromInterfaceIdAsync](displaymonitor_frominterfaceidasync_1923441009.md)

## -examples

