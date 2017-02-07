---
-api-id: M:Windows.Devices.Portable.ServiceDevice.GetDeviceSelector(Windows.Devices.Portable.ServiceDeviceType)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(Windows.Devices.Portable.ServiceDeviceType serviceType)
-->

# Windows.Devices.Portable.ServiceDevice.GetDeviceSelector

## -description
Returns an Advanced Query Syntax (AQS) string that is used to enumerate device services of the specified [ServiceDeviceType](servicedevicetype.md). This string is passed to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) or [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher.md) method.

## -parameters
### -param serviceType
The type of service to identify.

## -returns
The AQS string.

## -remarks

## -examples

## -see-also
[Windows 8 Device Experience: ](http://go.microsoft.com/fwlink/p/?linkid=241442), [Portable Device Services Sample]( http://go.microsoft.com/fwlink/p/?linkid=242031), [Enumerating Common Devices](http://msdn.microsoft.com/library/2deddbba-de46-409e-ac76-87419cb03eba)