---
-api-id: T:Windows.Gaming.Input.Custom.IHidGameControllerInputSink
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IHidGameControllerInputSink : IGameControllerInputSink
-->

# Windows.Gaming.Input.Custom.IHidGameControllerInputSink

## -description

Defines the methods necessary for a custom HID (Human Interface Device) controller interface.

## -remarks

This interface must be implemented by a HID custom controller class to receive input reports from the underlying HID device. No parsing or modifications are done on these reports; they are retrieved in their original format.

## -see-also

[Windows.Gaming.Input.Custom.IGameControllerInputSink](igamecontrollerinputsink.md)

## -examples

