---
-api-id: M:Windows.Devices.Lights.Lamp.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.Lights.Lamp.GetDeviceSelector

## -description
Returns the class selection string that you can use to enumerate lamp devices.

## -returns
The class selection string for lamp devices.

## -remarks
You can enumerate lamp devices by passing the class selection string returned by the [GetDeviceSelector](lamp_getdeviceselector.md) method to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) or [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher.md) method.

## -examples

## -see-also
