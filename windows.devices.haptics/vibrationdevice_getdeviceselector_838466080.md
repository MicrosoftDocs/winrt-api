---
-api-id: M:Windows.Devices.Haptics.VibrationDevice.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax.
public string VibrationDevice.GetDeviceSelector()
-->

# Windows.Devices.Haptics.VibrationDevice.GetDeviceSelector

## -description
Returns the class selection string that you can use to enumerate vibration devices.

## -returns
The class selection string for vibration devices.

## -remarks
You can enumerate vibration devices by passing the class selection string returned by the GetDeviceSelector() method to [FindAllAsync()](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) or [CreateWatcher()](../windows.devices.enumeration/deviceinformation_createwatcher_1506431823.md) method.

## -see-also

[FromIdAsync](vibrationdevice_fromidasync_1322863552.md)

## -examples

