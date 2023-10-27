---
-api-id: M:Windows.UI.Core.CoreComponentInputSource.GetCurrentKeyEventDeviceId
-api-type: winrt method
---

<!-- Method syntax
public string GetCurrentKeyEventDeviceId()
-->

# Windows.UI.Core.CoreComponentInputSource.GetCurrentKeyEventDeviceId

## -description
Retrieves the unique ID for the input device that generated this key event.

> GetCurrentKeyEventDeviceId is not supported for all input devices.

## -returns
A unique identifier for the input device associated with the key event, or an empty string. The same device can be assigned a different ID each time it is connected.

After a key event is processed, this method returns an empty string.

## -remarks
Use GetCurrentKeyEventDeviceId to differentiate between devices that can generate key events, such as multiple game controllers. The device id is useful for associating the input device with a specific user account.

To get a valid device ID, this method must be called from your [KeyUp](corecomponentinputsource_keyup.md) and [KeyDown](corecomponentinputsource_keydown.md) event handlers.

## -examples

## -see-also
