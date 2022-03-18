---
-api-id: M:Windows.Gaming.Input.Gamepad.GetCurrentReading
-api-type: winrt method
---

<!-- Method syntax
public Windows.Gaming.Input.GamepadReading GetCurrentReading()
-->

# Windows.Gaming.Input.Gamepad.GetCurrentReading

## -description
Gets a snapshot of the gamepad state.

## -returns
The current state of the gamepad.

## -remarks

This method gets the state of the gamepad at the moment you call it. For example, if you press the A button, then release the A button, and then call **GetCurrentReading**, it will return that the A button is not currently pressed.

There is no need to "flush the state" because the state of the gamepad is updated automatically. This method just returns a snapshot of the current state.

## -examples

## -see-also

[Windows.Gaming.Input.GamepadReading](gamepadreading.md)