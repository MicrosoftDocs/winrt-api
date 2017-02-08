---
-api-id: M:Windows.Media.Devices.MediaDeviceControl.TrySetAuto(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySetAuto(System.Boolean value)
-->

# Windows.Media.Devices.MediaDeviceControl.TrySetAuto

## -description
Enables or disables automatic adjustment of the camera setting.

## -parameters
### -param value
True to enable automatic adjustment; or false to disable automatic adjustment. If false, call [TrySetValue](mediadevicecontrol_trysetvalue.md) to adjust the setting.

## -returns
Returns true if the method succeeds, or false otherwise.

## -remarks
Depending on the setting and the camera model, the camera might not support automatic adjustment.

## -examples

## -see-also
