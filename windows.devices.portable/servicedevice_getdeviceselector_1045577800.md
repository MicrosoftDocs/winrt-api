---
-api-id: M:Windows.Devices.Portable.ServiceDevice.GetDeviceSelector(Windows.Devices.Portable.ServiceDeviceType)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(Windows.Devices.Portable.ServiceDeviceType serviceType)
-->

# Windows.Devices.Portable.ServiceDevice.GetDeviceSelector

## -description
Returns an Advanced Query Syntax (AQS) string that is used to enumerate device services of the specified [ServiceDeviceType](servicedevicetype.md). This string is passed to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) or [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_1506431823.md) method.

## -parameters
### -param serviceType
The type of service to identify.

## -returns
The AQS string.

## -remarks

## -examples

## -see-also
[Windows 8 Device Experience: ](http://msdn.microsoft.com/en-us/library/windows/hardware/br259108.aspx), [Enumerating Common Devices](/previous-versions/windows/apps/hh464974(v=win.10))