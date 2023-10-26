---
-api-id: P:Windows.UI.Core.AcceleratorKeyEventArgs.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.UI.Core.AcceleratorKeyEventArgs.DeviceId

## -description
Gets a unique ID for the input device that generated this key event.

Use DeviceId to differentiate between devices that can generate key events, such as multiple game controllers.

> DeviceId is not supported for all input devices.

## -property-value
A unique identifier for the input device associated with the key event, or an empty string. The same device can be assigned a different ID each time it is connected.

## -remarks
This property is useful for retrieving info for a specific user account associated with the input device.

## -examples

## -see-also
[CoreComponentInputSource.GetCurrentKeyEventDeviceId](corecomponentinputsource_getcurrentkeyeventdeviceid_498768106.md), [CoreWindow.GetCurrentKeyEventDeviceId](corewindow_getcurrentkeyeventdeviceid_498768106.md)
